using AutoMapper;
using CustomStorageLibrary.App.Interfaces;
using Microsoft.EntityFrameworkCore;
using SharedMomentsBackend.App.DB;
using SharedMomentsBackend.App.DB.Respositories.Interfaces;
using SharedMomentsBackend.App.Models.DTOs;
using SharedMomentsBackend.App.Models.DTOs.Moment;
using SharedMomentsBackend.App.Models.DTOs.Resource;
using SharedMomentsBackend.App.Models.Entities;
using SharedMomentsBackend.App.Services.Interfaces;

namespace SharedMomentsBackend.App.Services.Implementations
{
    public class MomentService : IMomentService
    {
        private readonly IMapper _mapper;
        IResourceManager _resourceManager;
        IMomentRepository _momentRepository;
        IResourceRepository _resourceRepository;
        IMomentResourceRepository _momentResourceRepository;

        public MomentService(
            IMapper mapper, 
            IResourceManager resourceManager,
            IMomentRepository momentRepository, 
            IResourceRepository resourceRepository,
            IMomentResourceRepository momentResourceRepository)
        {

            _mapper = mapper;
            _resourceManager = resourceManager;
            _momentRepository = momentRepository;
            _resourceRepository = resourceRepository;
            _momentResourceRepository = momentResourceRepository;
        }

        public async Task<ResultPattern<PaginateResponse<MomentResponse>>> GetMoments(FilterOwnerParams filterParams)
        {
            ResultPattern<PaginateResponse<MomentResponse>> result = new ResultPattern<PaginateResponse<MomentResponse>>();

            PaginateResponse<MomentResponse> paginateResult = new PaginateResponse<MomentResponse>();

            PaginateResponse<Moment> resultData = await _momentRepository.GetMoments(filterParams, $"{nameof(Moment.MomentResources)}.{nameof(Resource)}");

            paginateResult.List = resultData.List.Select(x => new MomentResponse
            {
                Id = x.Id,
                Title = x.Title,
                Description = x.Description,
                Date = x.Date,
                Place = x.Place,
                OwnerId = x.OwnerId,
                Resources = x.MomentResources.Select(x => new ResourceResponse
                {
                    Id = x.Resource.Id,
                    Url = x.Resource.Url,
                    Extension = x.Resource.Extension
                })
            });

            paginateResult.PageNumber = resultData.PageNumber;
            paginateResult.PageSize = resultData.PageSize;
            paginateResult.TotalRecords = resultData.TotalRecords;
            paginateResult.TotalPages = resultData.TotalPages;

            result.Data = paginateResult;

            return result;
        }

        public async Task<ResultPattern<MomentResponse>> CreateMoment(MomentRequest request, List<ResourceRequest> resources)
        {
            ResultPattern<MomentResponse> response = new ResultPattern<MomentResponse>();
            Moment moment = _mapper.Map<Moment>(request);

            if (await _momentRepository.Exists(x => x.Title == request.Title))
            {
                response.Message = "El título del momento ya está en uso.";
                response.StatusCode = 409; // Código de estado 409 Conflict
                response.IsSuccess = false;
                return response;
            }

            if (resources.Any())
            {
                List<MomentResource> _resources = new List<MomentResource>();
                int count = 0;
                foreach (ResourceRequest res in resources)
                {
                    string srcName = count == 0 ? $"{request.Title.Replace(" ", "")}" : $"{request.Title.Replace(" ", "")}_{count}";
                    CustomStorageLibrary.App.Models.Resource resource = await _resourceManager.UploadFile(
                    res.Stream, "moments", res.ContentType, srcName, res.Extension);
                    Resource newResource = new Resource
                    {
                        Name = resource.Name,
                        Url = resource.Url,
                        Extension = resource.Extension,
                        Path = resource.Path,
                        Size = resource.Size,
                    };
                    _resources.Add(new MomentResource { Resource = newResource });
                    count++;
                }
                moment.MomentResources = _resources;
            }

            await _momentRepository.Add(moment);

            response.Data = new MomentResponse
            {
                Id = moment.Id,
                Title = moment.Title,
                Description = moment.Description,
                Date = moment.Date,
                Place = moment.Place,
                OwnerId = moment.OwnerId,
                Resources = moment.MomentResources.Select(x => new ResourceResponse
                {
                    Id = x.Resource.Id,
                    Url = x.Resource.Url,
                    Extension = x.Resource.Extension
                }).ToList()
            };
            response.Message = "Momento creado correctamente.";
            return response;
        }
        public async Task<ResultPattern<MomentResponse>> GetMoment(Guid id)
        {
            ResultPattern<MomentResponse> response = new ResultPattern<MomentResponse>();
            bool exist = await _momentRepository.Exists(x => x.Id == id);
            if (!exist)
            {
                response.Message = "Momento no encontrado.";
                response.StatusCode = 404;
                response.IsSuccess = false;
                return response;
            }
            Moment moment = await _momentRepository.GetById(id, $"{nameof(Moment.MomentResources)}.{nameof(Resource)}");
            response.Data = new MomentResponse
            {
                Id = moment.Id,
                Title = moment.Title,
                Description = moment.Description,
                Date = moment.Date,
                Place = moment.Place,
                OwnerId = moment.OwnerId,
                Resources = moment.MomentResources.Select(x => new ResourceResponse
                {
                    Id = x.Resource.Id,
                    Url = x.Resource.Url,
                    Extension = x.Resource.Extension
                }).ToList()
            };
            return response;
        }

        public async Task<ResultPattern<MomentResponse>> UpdateMoment(Guid id, MomentRequest request, List<ResourceRequest> resources)
        {
            ResultPattern<MomentResponse> response = new ResultPattern<MomentResponse>();

            bool exist = await _momentRepository.Exists(x => x.Id == id);
            if (!exist)
            {
                response.Message = "Momento no encontrado.";
                response.StatusCode = 404;
                response.IsSuccess = false;
                return response;
            }
            if (await _momentRepository.Exists(x => x.Title == request.Title && x.Id != id))
            {
                response.Message = "El título del momento ya está en uso.";
                response.StatusCode = 409; // Código de estado 409 Conflict
                response.IsSuccess = false;
                return response;
            }

            Moment moment = await _momentRepository.GetById(id, $"{nameof(Moment.MomentResources)}.{nameof(Resource)}");

            if (resources.Any())
            {
                int count = await MaxNumerationResource(id) + 1;
                foreach (ResourceRequest res in resources)
                {
                    string srcName = count == 0 ? $"{request.Title.Replace(" ", "")}" : $"{request.Title.Replace(" ", "")}_{count}";
                    CustomStorageLibrary.App.Models.Resource resource = await _resourceManager.UploadFile(
                    res.Stream, "moments", res.ContentType, srcName, res.Extension);

                    Resource newResource = new Resource
                    {
                        Name = resource.Name,
                        Url = resource.Url,
                        Extension = resource.Extension,
                        Path = resource.Path,
                        Size = resource.Size,
                    };
                    moment.MomentResources.Add(new MomentResource { Resource = newResource });
                    count++;
                }
            }

            moment.Title = request.Title;
            moment.Description = request.Description;
            moment.Date = request.Date;
            moment.Place = request.Place;

            moment.UpdatedAt = DateTime.UtcNow;

            await _momentRepository.Update(moment);

            response.Data = new MomentResponse
            {
                Id = moment.Id,
                Title = moment.Title,
                Description = moment.Description,
                Date = moment.Date,
                Place = moment.Place,
                OwnerId = moment.OwnerId,
                Resources = moment.MomentResources.Select(x => new ResourceResponse
                {
                    Id = x.Resource.Id,
                    Url = x.Resource.Url,
                    Extension = x.Resource.Extension
                }).ToList()
            };
            response.Message = "Momento actualizado correctamente.";
            return response;
        }

        public async Task<ResultPattern<bool>> DeleteMoment(Guid id)
        {
            ResultPattern<bool> response = new ResultPattern<bool>();
            bool exist = await _momentRepository.Exists(x => x.Id == id);
            if (!exist)
            {
                response.Message = "Momento no encontrado.";
                response.StatusCode = 404;
                response.IsSuccess = false;
                return response;
            }
            Moment moment = await _momentRepository.GetById(id, $"{nameof(Moment.MomentResources)}.{nameof(Resource)}");

            IEnumerable<Resource> res = moment.MomentResources.Select(x => x.Resource);

            foreach (Resource r in res)
            {
                await _resourceManager.DeleteFile("moments", r.Name, r.Extension);
            }

            await _resourceRepository.DeleteRange(res);

            await _momentRepository.Delete(moment.Id);

            response.Data = true;
            response.Message = "Momento eliminado correctamente.";
            return response;
        }

        public async Task<int> MaxNumerationResource(Guid momentId)
        {
            if (!await _momentResourceRepository.Exists(x => x.MomentId == momentId))
            {
                return -1;
            }
            IEnumerable<MomentResource> moments = await _momentResourceRepository.GetAll(filter: x => x.MomentId == momentId, includeProperties: $"{nameof(MomentResource.Resource)}");
            var maxNumber = moments
                .Select(r => r.Resource.Name).ToList()
                .Where(name => name.Contains('_')).ToList()
                .Select(name => name.Split("_".ToCharArray())[1])
                .Max();
            return maxNumber == null ? 0 : int.Parse(maxNumber);
        }
    }
}

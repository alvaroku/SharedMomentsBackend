using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SharedMomentsBackend.App.DB;
using SharedMomentsBackend.App.Models.DTOs;
using SharedMomentsBackend.App.Models.Entities;
using SharedMomentsBackend.App.Services.Interfaces;

namespace SharedMomentsBackend.App.Services.Implementations
{
    public class MomentService : IMomentService
    {
        IConfiguration _configuration;
        ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;
        IResourceManager _resourceManager;
        public MomentService(ApplicationDbContext dbContext, IConfiguration configuration, IMapper mapper, IResourceManager resourceManager)
        {
            _dbContext = dbContext;
            _configuration = configuration;
            _mapper = mapper;
            _resourceManager = resourceManager;
        }

        public async Task<ResultPattern<PaginateResponse<MomentResponse>>> GetMoments(DefaultFilterParams filterParams)
        {
            ResultPattern<PaginateResponse<MomentResponse>> result = new ResultPattern<PaginateResponse<MomentResponse>>();

            PaginateResponse<MomentResponse> paginateResult = new PaginateResponse<MomentResponse>();

            paginateResult.List = await _dbContext.Moments.Select(x => new MomentResponse
            {
                Id = x.Id,
                Title = x.Title,
                Description = x.Description,
                Date = x.Date,
                Place = x.Place,
                Resources = x.MomentResources.Select(x => new ResourceResponse
                {
                    Id = x.Resource.Id,
                    Url = x.Resource.Url,
                    Extension = x.Resource.Extension
                }).ToList()
            }).ToListAsync();

            result.Data = paginateResult;
            return result;
        }

        public async Task<ResultPattern<MomentResponse>> CreateMoment(MomentRequest request, List<ResourceRequest> resources)
        {
            ResultPattern<MomentResponse> response = new ResultPattern<MomentResponse>();
            Moment moment = _mapper.Map<Moment>(request);

            if (await _dbContext.Moments.AnyAsync(x => x.Title == request.Title))
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
                    Resource newResource = await _resourceManager.UploadFile(
                    res.Stream, "moments", res.ContentType, srcName, res.Extension);
                    _resources.Add(new MomentResource { Resource = newResource });
                    count++;
                }
                moment.MomentResources = _resources;
            }

            await _dbContext.Moments.AddAsync(moment);
            await _dbContext.SaveChangesAsync();
            response.Data = new MomentResponse
            {
                Id = moment.Id,
                Title = moment.Title,
                Description = moment.Description,
                Date = moment.Date,
                Place = moment.Place,
                Resources = moment.MomentResources.Select(x => new ResourceResponse
                {
                    Id = x.Resource.Id,
                    Url = x.Resource.Url,
                    Extension = x.Resource.Extension
                }).ToList()
            };
            response.Message = "Momento creado correctamente";
            return response;
        }
        public async Task<ResultPattern<MomentResponse>> GetMoment(Guid id)
        {
            ResultPattern<MomentResponse> response = new ResultPattern<MomentResponse>();
            bool exist = await _dbContext.Moments.AnyAsync(x => x.Id == id);
            if (!exist)
            {
                response.Message = "Momento no encontrado";
                response.StatusCode = 404;
                return response;
            }
            Moment moment = await _dbContext.Moments
                .Include(x => x.MomentResources)
                .ThenInclude(z => z.Resource).FirstAsync(x => x.Id == id);
            response.Data = new MomentResponse
            {
                Id = moment.Id,
                Title = moment.Title,
                Description = moment.Description,
                Date = moment.Date,
                Place = moment.Place,
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

            bool exist = await _dbContext.Moments.AnyAsync(x => x.Id == id);
            if (!exist)
            {
                response.Message = "Momento no encontrado";
                response.StatusCode = 404;
                return response;
            }
            if (await _dbContext.Moments.AnyAsync(x => x.Title == request.Title && x.Id != id))
            {
                response.Message = "El título del momento ya está en uso.";
                response.StatusCode = 409; // Código de estado 409 Conflict
                response.IsSuccess = false;
                return response;
            }
            Moment moment = await _dbContext.Moments
                .Include(x => x.MomentResources)
                .ThenInclude(z => z.Resource).FirstAsync(x => x.Id == id);

            if (resources.Any())
            {
                int count = await MaxNumerationResource(id) + 1;
                foreach (ResourceRequest res in resources)
                {
                    string srcName = count == 0 ? $"{request.Title.Replace(" ", "")}" : $"{request.Title.Replace(" ", "")}_{count}";
                    Resource newResource = await _resourceManager.UploadFile(
                    res.Stream, "moments", res.ContentType, srcName, res.Extension);
                    moment.MomentResources.Add(new MomentResource { Resource = newResource });
                    count++;
                }
            }

            moment.Title = request.Title;
            moment.Description = request.Description;
            moment.Date = request.Date;
            moment.Place = request.Place;

            moment.UpdatedAt = DateTime.UtcNow;

            _dbContext.Moments.Update(moment);
            await _dbContext.SaveChangesAsync();
            response.Data = new MomentResponse
            {
                Id = moment.Id,
                Title = moment.Title,
                Description = moment.Description,
                Date = moment.Date,
                Place = moment.Place,
                Resources = moment.MomentResources.Select(x => new ResourceResponse
                {
                    Id = x.Resource.Id,
                    Url = x.Resource.Url,
                    Extension = x.Resource.Extension
                }).ToList()
            };
            response.Message = "Momento actualizado correctamente";
            return response;
        }

        public async Task<ResultPattern<bool>> DeleteMoment(Guid id)
        {
            ResultPattern<bool> response = new ResultPattern<bool>();
            bool exist = await _dbContext.Moments.AnyAsync(x => x.Id == id);
            if (!exist)
            {
                response.Message = "Momento no encontrado";
                response.StatusCode = 404;
                return response;
            }
            Moment moment = await _dbContext.Moments
                .Include(x => x.MomentResources)
                .ThenInclude(z => z.Resource)
                .FirstAsync(x => x.Id == id);

            IEnumerable<Resource> res = moment.MomentResources.Select(x => x.Resource);

            foreach (Resource r in res)
            {
                await _resourceManager.DeleteFile("moments", r.Name, r.Extension);
            }

            _dbContext.Resources.RemoveRange(res);
            _dbContext.Moments.Remove(moment);

            await _dbContext.SaveChangesAsync();
            response.Data = true;
            response.Message = "Momento eliminado correctamente";
            return response;
        }

        public async Task<int> MaxNumerationResource(Guid momentId)
        {
            if (!await _dbContext.MomentResources.AnyAsync(x => x.MomentId == momentId))
            {
                return -1;
            }
            var maxNumber = _dbContext.MomentResources
                .Include(r => r.Resource)
                .Where(x => x.MomentId == momentId)
                .Select(r => r.Resource.Name).ToList()
                .Where(name => name.Contains('_')).ToList()
                .Select(name => name.Split("_".ToCharArray())[1])
                .Max();
            return maxNumber == null ? 0 : int.Parse(maxNumber);
        }
    }
}

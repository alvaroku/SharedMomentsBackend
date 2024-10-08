using AutoMapper;
using CustomStorageLibrary.App.Interfaces;
using EmailSenderLibrary.App.Interfaces;
using EmailSenderLibrary.App.Models;
using SharedMomentsBackend.App.DB.Respositories.Base.Interfaces;
using SharedMomentsBackend.App.DB.Respositories.Implementations;
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
        IMomentUserRepository _momentUserRepository;
        IUserRepository _userRepository;
        IUnitOfWork _unitOfWork;
        IAlbumRepository _albumRepository;
        IWebHostEnvironment _hostingEnvironment;
        IEmailSender _emailSender;
        IConfiguration _configuration;
        public MomentService(
            IMapper mapper,
            IResourceManager resourceManager,
            IMomentRepository momentRepository,
            IResourceRepository resourceRepository,
            IMomentResourceRepository momentResourceRepository,
            IMomentUserRepository momentUserRepository,
            IUserRepository userRepository,
            IUnitOfWork unitOfWork,
            IAlbumRepository albumRepository,
            IWebHostEnvironment hostingEnvironment,
            IEmailSender emailSender,
            IConfiguration configuration)
        {

            _mapper = mapper;
            _resourceManager = resourceManager;
            _momentRepository = momentRepository;
            _resourceRepository = resourceRepository;
            _momentResourceRepository = momentResourceRepository;
            _momentUserRepository = momentUserRepository;
            _userRepository = userRepository;
            _unitOfWork = unitOfWork;
            _albumRepository = albumRepository;
            _hostingEnvironment = hostingEnvironment;
            _emailSender = emailSender;
            _configuration = configuration;
        }

        public async Task<ResultPattern<PaginateResponse<MomentResponse>>> GetMoments(FilterMomentParams filterParams)
        {
            ResultPattern<PaginateResponse<MomentResponse>> result = new ResultPattern<PaginateResponse<MomentResponse>>();

            PaginateResponse<MomentResponse> paginateResult = new PaginateResponse<MomentResponse>();

            PaginateResponse<Moment> resultData = await _momentRepository
                .GetMoments(filterParams, $"{nameof(Moment.MomentResources)}.{nameof(Resource)}," +
                                          $"{nameof(Moment.MomentUsers)}.{nameof(User)}.{nameof(User.Profile)}," +
                                          $"{nameof(Moment.Owner)}.{nameof(User.Profile)}");
            
            paginateResult.List = resultData.List.Select(x => new MomentResponse
            {
                Id = x.Id,
                Title = x.Title,
                Description = x.Description,
                Date = x.Date,
                Place = x.Place,
                OwnerId = x.OwnerId,
                OwnerName = x.Owner.Name,
                ProfileUrl = x.Owner.Profile?.Url,
                AlbumId = x.AlbumId,
                Resources = x.MomentResources.Select(x => new ResourceResponse
                {
                    Id = x.Resource.Id,
                    Url = x.Resource.Url,
                    Extension = x.Resource.Extension
                }),
                SharedWith = x.MomentUsers.Select(x => new MomentUserResponse
                {
                    UserId = x.UserId,
                    UserName = x.User.Name,
                    ProfileUrl = x.User.Profile?.Url
                })
            });

            paginateResult.PageNumber = resultData.PageNumber;
            paginateResult.PageSize = resultData.PageSize;
            paginateResult.TotalRecords = resultData.TotalRecords;
            paginateResult.TotalPages = resultData.TotalPages;

            result.Data = paginateResult;

            return result;
        }
        public async Task<ResultPattern<PaginateResponse<MomentResponse>>> GetSharedWithMe(FilterMomentParams filterParams)
        {
            ResultPattern<PaginateResponse<MomentResponse>> result = new ResultPattern<PaginateResponse<MomentResponse>>();

            PaginateResponse<MomentResponse> paginateResult = new PaginateResponse<MomentResponse>();

            PaginateResponse<MomentUser> resultData = await _momentUserRepository
                .GetSharedWithMe(filterParams, $"{nameof(MomentUser.Moment)}.{nameof(Moment.MomentResources)}.{nameof(MomentResource.Resource)}," +
                $"{nameof(MomentUser.Moment)}.{nameof(Moment.Owner)}.{nameof(User.Profile)}");

            paginateResult.List = resultData.List.Select(x=>x.Moment).Select(x => new MomentResponse
            {
                Id = x.Id,
                Title = x.Title,
                Description = x.Description,
                Date = x.Date,
                Place = x.Place,
                OwnerId = x.OwnerId,
                OwnerName = x.Owner.Name,
                ProfileUrl = x.Owner.Profile?.Url,
                Resources = x.MomentResources.Select(x => new ResourceResponse
                {
                    Id = x.Resource.Id,
                    Url = x.Resource.Url,
                    Extension = x.Resource.Extension
                }),
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
                    res.Stream, $"{_hostingEnvironment.EnvironmentName}/moments", res.ContentType, srcName, res.Extension);
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
                    res.Stream, $"{_hostingEnvironment.EnvironmentName}/moments", res.ContentType, srcName, res.Extension);

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

            if (await _momentUserRepository.Exists(x => x.MomentId == id))
            {
                response.Message = "No se puede eliminar un momento compartido. Por favor asegúrese de haber eliminado a todas las personas compartidas.";
                response.StatusCode = 400;
                response.IsSuccess = false;
                return response;
            }
            Moment moment = await _momentRepository.GetById(id, $"{nameof(Moment.MomentResources)}.{nameof(Resource)}");

            IEnumerable<Resource> res = moment.MomentResources.Select(x => x.Resource);

            foreach (Resource r in res)
            {
                await _resourceManager.DeleteFile($"{_hostingEnvironment.EnvironmentName}/moments", r.Name, r.Extension);
            }

            await _resourceRepository.DeleteRange(res);

            await _momentRepository.Delete(moment.Id);

            response.Data = true;
            response.Message = "Momento eliminado correctamente.";
            return response;
        }

        public async Task<ResultPattern<IEnumerable<ShareMomentResponse>>> Share(Guid id, ShareMomentRequest request)
        {
            ResultPattern<IEnumerable<ShareMomentResponse>> response = new ResultPattern<IEnumerable<ShareMomentResponse>>();
            if (!await _momentRepository.Exists(x => x.Id == id))
            {
                response.Message = "Momento no encontrado.";
                response.StatusCode = 404;
                response.IsSuccess = false;
                return response;
            }

            if (request.SharedUsersId.Count() == 0)
            {
                response.Message = "Debe seleccionar por lo menos un usuario.";
                response.StatusCode = 400;
                response.IsSuccess = false;
                return response;
            }

            int countUsers = await _userRepository.Count(u => request.SharedUsersId.Contains(u.Id));

            if (countUsers != request.SharedUsersId.Count())
            {
                response.Message = "Uno o más usuarios no existen.";
                response.StatusCode = 404;
                response.IsSuccess = false;
                return response;
            }

            Moment moment = await _momentRepository.GetById(id, $"{nameof(Moment.MomentUsers)}.{nameof(User)}");

            request.SharedUsersId = request.SharedUsersId.Where(userId => !moment.MomentUsers.Any(mu => mu.UserId == userId)).ToArray();

            request.SharedUsersId.ToList().ForEach(userId =>
            {
                moment.MomentUsers.Add(new MomentUser { UserId = userId });
            });

            await _unitOfWork.Commit();

            moment = await _momentRepository.GetById(id, $"{nameof(Moment.Owner)},{nameof(Moment.MomentUsers)}.{nameof(User)}.{nameof(User.Profile)}");
            
            string sharedBy = moment.Owner.Name;
            string title = moment.Title;
            moment.MomentUsers.Where(x => request.SharedUsersId.Contains(x.UserId)).ToList().ForEach(async x =>
            {
                
                string header = "Momento compartido";
                string dynamicContent = Constants.templateShareMoment(x.User.Name,sharedBy,title, _configuration.GetValue<string>("frontUrl"));
                string htmlBody = string.Format(Constants.htmlTemplate, header, dynamicContent);
                EmailDataRequest emailDataRequest = new EmailDataRequest
                {
                    Subject = header,
                    Body = htmlBody,
                    EmailTo = x.User.Email
                };
                await _emailSender.SendEmail(emailDataRequest);
            });
            response.Message = "Momento compartido correctamente.";
            response.Data = moment.MomentUsers.Where(x=>request.SharedUsersId.Contains(x.UserId)).Select(x => new ShareMomentResponse
            {
                UserId = x.UserId,
                UserName = x.User.Name,
                ProfileUrl = x.User.Profile?.Url
            });
           
            return response;
        }
        public async Task<ResultPattern<bool>> DeleteShare(Guid userId,Guid momentId)
        {
            ResultPattern<bool> response = new ResultPattern<bool>();

            bool exist = await _momentRepository.Exists(x => x.Id == momentId);
            if (!exist)
            {
                response.Message = "Momento no encontrado.";
                response.StatusCode = 404;
                response.IsSuccess = false;
                return response;
            }
            exist = await _userRepository.Exists(x => x.Id == userId);
            if (!exist)
            {
                response.Message = "Usuario no encontrado.";
                response.StatusCode = 404;
                response.IsSuccess = false;
                return response;
            }

            exist = await _momentUserRepository.Exists(x => x.UserId == userId && x.MomentId == momentId);
            if (!exist)
            {
                response.Message = "No se encontró relación entre el momento y usuario proporcionado.";
                response.StatusCode = 404;
                response.IsSuccess = false;
                return response;
            }

            MomentUser momentUser = await _momentUserRepository.GetFirstOrDefault(x => x.UserId == userId && x.MomentId == momentId);

            await _momentUserRepository.Delete(momentUser.Id);

            response.Data = true;
            response.Message = "El momento se ha dejado de compartir con el usuario.";
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

        public async Task<ResultPattern<AddToAlbumResponse>> AddToAlbum(AddToAlbumRequest request)
        {
            ResultPattern<AddToAlbumResponse> result = new ResultPattern<AddToAlbumResponse>();

            if(!await _momentRepository.Exists(x => x.Id == request.MomentId && x.OwnerId == request.OwnerId))
            {
                result.Message = "Momento no encontrado.";
                result.StatusCode = 404;
                result.IsSuccess = false;
                return result;
            }

            Moment moment = await _momentRepository.GetById(request.MomentId);

            if (!request.AlbumId.HasValue)
            {
                moment.AlbumId = null;
                moment.Album = null;
                await _unitOfWork.Commit();
                result.Message = "Momento eliminado del álbum correctamente.";
                result.Data = new AddToAlbumResponse
                {
                    AlbumId = null,
                };
                return result;
            }

            if(!await _albumRepository.Exists(x=>x.Id == request.AlbumId && x.OwnerId==request.OwnerId))
            {
                result.Message = "Álbum no encontrado.";
                result.StatusCode = 404;
                result.IsSuccess = false;
                return result;
            }

            Album album = await _albumRepository.GetById(request.AlbumId.Value);
            moment.UpdatedAt = DateTime.UtcNow;

            moment.Album = album;

            await _unitOfWork.Commit();

            result.Data = new AddToAlbumResponse
            {
               AlbumId = album.Id,
            };
            result.Message = "Momento agregado al álbum correctamente.";
            return result;
        }
    }
}

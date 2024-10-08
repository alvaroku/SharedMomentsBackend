using AutoMapper;
using EmailSenderLibrary.App.Interfaces;
using EmailSenderLibrary.App.Models;
using SharedMomentsBackend.App.DB.Respositories.Base.Interfaces;
using SharedMomentsBackend.App.DB.Respositories.Interfaces;
using SharedMomentsBackend.App.Models.DTOs;
using SharedMomentsBackend.App.Models.DTOs.Album;
using SharedMomentsBackend.App.Models.DTOs.Moment;
using SharedMomentsBackend.App.Models.Entities;
using SharedMomentsBackend.App.Services.Interfaces;

namespace SharedMomentsBackend.App.Services.Implementations
{
    public class AlbumService : IAlbumService
    {
        private readonly IMapper _mapper;
        IAlbumRepository _albumRepository;
        IAlbumUserRepository _albumUserRepository;
        IUserRepository _userRepository;
        IUnitOfWork _unitOfWork;
        IEmailSender _emailSender;
        IConfiguration _configuration;
        public AlbumService(
            IMapper mapper,
            IAlbumRepository albumRepository,
            IAlbumUserRepository albumUserRepository,
            IUserRepository userRepository,
            IUnitOfWork unitOfWork,
            IEmailSender emailSender,
            IConfiguration configuration)
        {

            _mapper = mapper;
            _albumRepository = albumRepository;
            _albumUserRepository = albumUserRepository;
            _userRepository = userRepository;
            _unitOfWork = unitOfWork;
            _emailSender = emailSender;
            _configuration = configuration;
        }

        public async Task<ResultPattern<PaginateResponse<AlbumResponse>>> GetAlbums(FilterOwnerParams filterParams)
        {
            ResultPattern<PaginateResponse<AlbumResponse>> result = new ResultPattern<PaginateResponse<AlbumResponse>>();

            PaginateResponse<AlbumResponse> paginateResult = new PaginateResponse<AlbumResponse>();

            PaginateResponse<Album> resultData = await _albumRepository
                .GetAlbums(filterParams, $"{nameof(Album.AlbumUsers)}.{nameof(User)}.{nameof(User.Profile)}," +
                $"{nameof(Album.Owner)}.{nameof(User.Profile)}");

            paginateResult.List = resultData.List.Select(x => new AlbumResponse
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                OwnerId = x.OwnerId,
                OwnerName = x.Owner.Name,
                ProfileUrl = x.Owner.Profile?.Url,
                SharedWith = x.AlbumUsers.Select(x => new AlbumUserResponse
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
        public async Task<ResultPattern<PaginateResponse<AlbumResponse>>> GetSharedWithMe(FilterOwnerParams filterParams)
        {
            ResultPattern<PaginateResponse<AlbumResponse>> result = new ResultPattern<PaginateResponse<AlbumResponse>>();

            PaginateResponse<AlbumResponse> paginateResult = new PaginateResponse<AlbumResponse>();

            PaginateResponse<AlbumUser> resultData = await _albumUserRepository
                .GetSharedWithMe(filterParams, $"{nameof(AlbumUser.Album)}.{nameof(Album.Owner)}.{nameof(User.Profile)}");

            paginateResult.List = resultData.List.Select(x => x.Album).Select(x => new AlbumResponse
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                OwnerId = x.OwnerId,
                OwnerName = x.Owner.Name,
                ProfileUrl = x.Owner.Profile?.Url
            });

            paginateResult.PageNumber = resultData.PageNumber;
            paginateResult.PageSize = resultData.PageSize;
            paginateResult.TotalRecords = resultData.TotalRecords;
            paginateResult.TotalPages = resultData.TotalPages;

            result.Data = paginateResult;

            return result;
        }
        public async Task<ResultPattern<AlbumResponse>> CreateAlbum(AlbumRequest request)
        {
            ResultPattern<AlbumResponse> response = new ResultPattern<AlbumResponse>();
            Album moment = _mapper.Map<Album>(request);

            if (await _albumRepository.Exists(x => x.Name == request.Name))
            {
                response.Message = "El nombre del albúm ya está en uso.";
                response.StatusCode = 409; // Código de estado 409 Conflict
                response.IsSuccess = false;
                return response;
            }

            await _albumRepository.Add(moment);

            response.Data = new AlbumResponse
            {
                Id = moment.Id,
                Name = moment.Name,
                Description = moment.Description,
                OwnerId = moment.OwnerId,
            };
            response.Message = "Albúm creado correctamente.";
            return response;
        }
        public async Task<ResultPattern<AlbumResponse>> GetAlbum(Guid id)
        {
            ResultPattern<AlbumResponse> response = new ResultPattern<AlbumResponse>();
            bool exist = await _albumRepository.Exists(x => x.Id == id);
            if (!exist)
            {
                response.Message = "Albúm no encontrado.";
                response.StatusCode = 404;
                response.IsSuccess = false;
                return response;
            }
            Album moment = await _albumRepository.GetById(id);
            response.Data = new AlbumResponse
            {
                Id = moment.Id,
                Name = moment.Name,
                Description = moment.Description,
                OwnerId = moment.OwnerId
            };
            return response;
        }

        public async Task<ResultPattern<AlbumResponse>> UpdateAlbum(Guid id, AlbumRequest request)
        {
            ResultPattern<AlbumResponse> response = new ResultPattern<AlbumResponse>();

            bool exist = await _albumRepository.Exists(x => x.Id == id);
            if (!exist)
            {
                response.Message = "Albúm no encontrado.";
                response.StatusCode = 404;
                response.IsSuccess = false;
                return response;
            }
            if (await _albumRepository.Exists(x => x.Name == request.Name && x.Id != id))
            {
                response.Message = "El nombre del albúm ya está en uso.";
                response.StatusCode = 409; // Código de estado 409 Conflict
                response.IsSuccess = false;
                return response;
            }

            Album moment = await _albumRepository.GetById(id);

            moment.Name = request.Name;
            moment.Description = request.Description;

            moment.UpdatedAt = DateTime.UtcNow;

            await _albumRepository.Update(moment);

            response.Data = new AlbumResponse
            {
                Id = moment.Id,
                Name = moment.Name,
                Description = moment.Description,
                OwnerId = moment.OwnerId
            };
            response.Message = "Albúm actualizado correctamente.";
            return response;
        }

        public async Task<ResultPattern<bool>> DeleteAlbum(Guid id)
        {
            ResultPattern<bool> response = new ResultPattern<bool>();
            bool exist = await _albumRepository.Exists(x => x.Id == id);
            if (!exist)
            {
                response.Message = "Momento no encontrado.";
                response.StatusCode = 404;
                response.IsSuccess = false;
                return response;
            }

            if(await _albumUserRepository.Exists(x => x.AlbumId == id))
            {
                response.Message = "No se puede eliminar un albúm compartido. Por favor asegúrese de haber eliminado a todas las personas compartidas.";
                response.StatusCode = 400;
                response.IsSuccess = false;
                return response;
            }
            await _albumRepository.Delete(id);

            response.Data = true;
            response.Message = "Albúm eliminado correctamente.";
            return response;
        }

        public async Task<ResultPattern<IEnumerable<ShareAlbumResponse>>> Share(Guid id, ShareAlbumRequest request)
        {
            ResultPattern<IEnumerable<ShareAlbumResponse>> response = new ResultPattern<IEnumerable<ShareAlbumResponse>>();
            if (!await _albumRepository.Exists(x => x.Id == id))
            {
                response.Message = "Albúm no encontrado.";
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

            Album moment = await _albumRepository.GetById(id, $"{nameof(Album.AlbumUsers)}.{nameof(User)}");

            request.SharedUsersId = request.SharedUsersId.Where(userId => !moment.AlbumUsers.Any(mu => mu.UserId == userId)).ToArray();

            request.SharedUsersId.ToList().ForEach(userId =>
            {
                moment.AlbumUsers.Add(new AlbumUser { UserId = userId });
            });

            await _unitOfWork.Commit();

            moment = await _albumRepository.GetById(id, $"{nameof(Album.Owner)},{nameof(Album.AlbumUsers)}.{nameof(User)}.{nameof(User.Profile)}");

            string sharedBy = moment.Owner.Name;
            string title = moment.Name;
            moment.AlbumUsers.Where(x => request.SharedUsersId.Contains(x.UserId)).ToList().ForEach(async x =>
            {

                string header = "Albúm compartido";
                string dynamicContent = Constants.templateShareAlbum(x.User.Name, sharedBy, title, _configuration.GetValue<string>("frontUrl"));
                string htmlBody = string.Format(Constants.htmlTemplate, header, dynamicContent);
                EmailDataRequest emailDataRequest = new EmailDataRequest
                {
                    Subject = header,
                    Body = htmlBody,
                    EmailTo = x.User.Email
                };
                await _emailSender.SendEmail(emailDataRequest);
            });

            response.Data = moment.AlbumUsers.Where(x => request.SharedUsersId.Contains(x.UserId)).Select(x => new ShareAlbumResponse
            {
                UserId = x.UserId,
                UserName = x.User.Name,
                ProfileUrl = x.User.Profile?.Url
            });
            response.Message = "Albúm compartido correctamente.";
            return response;
        }
        public async Task<ResultPattern<bool>> DeleteShare(Guid userId, Guid albumId)
        {
            ResultPattern<bool> response = new ResultPattern<bool>();

            bool exist = await _albumRepository.Exists(x => x.Id == albumId);
            if (!exist)
            {
                response.Message = "Albúm no encontrado.";
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

            exist = await _albumUserRepository.Exists(x => x.UserId == userId && x.AlbumId == albumId);
            if (!exist)
            {
                response.Message = "No se encontró relación entre el albúm y usuario proporcionado.";
                response.StatusCode = 404;
                response.IsSuccess = false;
                return response;
            }

            AlbumUser momentUser = await _albumUserRepository.GetFirstOrDefault(x => x.UserId == userId && x.AlbumId == albumId);

            await _albumUserRepository.Delete(momentUser.Id);

            response.Data = true;
            response.Message = "El albúm se ha dejado de compartir con el usuario.";
            return response;
        }
        public async Task<ResultPattern<IEnumerable<DataDropDown>>> GetMyAlbums(DefaultFilterParams filterParams, Guid ownerId)
        {
            ResultPattern<IEnumerable<DataDropDown>> response = new ResultPattern<IEnumerable<DataDropDown>>();

            IEnumerable<Album> users = await _albumRepository.GetAll(filter: x => x.OwnerId == ownerId);

            response.Data = users.Select(x => new DataDropDown
            {
                Id = x.Id,
                Label = x.Name
            });
            return response;
        }
    }
}

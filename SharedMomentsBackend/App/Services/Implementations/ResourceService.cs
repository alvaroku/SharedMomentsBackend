using AutoMapper;
using CustomStorageLibrary.App.Interfaces;
using SharedMomentsBackend.App.DB.Respositories.Interfaces;
using SharedMomentsBackend.App.Models.DTOs;
using SharedMomentsBackend.App.Models.Entities;
using SharedMomentsBackend.App.Services.Interfaces;

namespace SharedMomentsBackend.App.Services.Implementations
{
    public class ResourceService : IResourceService
    {

        private readonly IMapper _mapper;
        IResourceManager _resourceManager;
        IResourceRepository _resourceRepository;
        IWebHostEnvironment _hostEnvironment;
        public ResourceService(IMapper mapper, IResourceManager resourceManager, IResourceRepository resourceRepository,IWebHostEnvironment webHostEnvironment)
        {

            _mapper = mapper;
            _resourceManager = resourceManager;
            _resourceRepository = resourceRepository;
            _hostEnvironment = webHostEnvironment;
        }
        public async Task<ResultPattern<bool>> DeleteResource(Guid id)
        {
            ResultPattern<bool> response = new ResultPattern<bool>();
            bool exist = await _resourceRepository.Exists(x => x.Id == id);
            if (!exist)
            {
                response.Message = "Recurso no encontrado.";
                response.StatusCode = 404;
                return response;
            }
            Resource resource = await _resourceRepository.GetFirstOrDefault(x => x.Id == id, includeProperties: $"{nameof(Resource.MomentResources)}");

            string path = resource.MomentResources.Any() ? "moments" : "users";

            await _resourceManager.DeleteFile($"{_hostEnvironment.EnvironmentName}/{path}", resource.Name, resource.Extension);

            await _resourceRepository.Delete(resource.Id);

            response.Data = true;
            response.Message = "Recurso eliminado correctamente.";
            return response;
        }
    }
}

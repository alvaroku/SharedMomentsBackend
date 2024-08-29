using AutoMapper;
using CustomStorageLibrary.App.Interfaces;
using Microsoft.EntityFrameworkCore;
using SharedMomentsBackend.App.DB;
using SharedMomentsBackend.App.Models.DTOs;
using SharedMomentsBackend.App.Models.Entities;
using SharedMomentsBackend.App.Services.Interfaces;

namespace SharedMomentsBackend.App.Services.Implementations
{
    public class ResourceService:IResourceService
    {
        IConfiguration _configuration;
        ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;
        IResourceManager _resourceManager;
        public ResourceService(ApplicationDbContext dbContext, IConfiguration configuration, IMapper mapper, IResourceManager resourceManager)
        {
            _dbContext = dbContext;
            _configuration = configuration;
            _mapper = mapper;
            _resourceManager = resourceManager;
        }
        public async Task<ResultPattern<bool>> DeleteResource(Guid id)
        {
            ResultPattern<bool> response = new ResultPattern<bool>();
            bool exist = await _dbContext.Resources.AnyAsync(x => x.Id == id);
            if (!exist)
            {
                response.Message = "Recurso no encontrado.";
                response.StatusCode = 404;
                return response;
            }
            Resource resource = await _dbContext.Resources.FirstOrDefaultAsync(x => x.Id == id);
            _resourceManager.DeleteFile("moments",resource.Name,resource.Extension);

            _dbContext.Resources.Remove(resource);
            await _dbContext.SaveChangesAsync();
            response.Data = true;
            response.Message = "Recurso eliminado correctamente.";
            return response;
        }
    }
}

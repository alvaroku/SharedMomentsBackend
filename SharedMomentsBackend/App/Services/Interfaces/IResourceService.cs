using SharedMomentsBackend.App.Models.DTOs;

namespace SharedMomentsBackend.App.Services.Interfaces
{
    public interface IResourceService
    {
        Task<ResultPattern<bool>> DeleteResource(Guid id);
    }
}

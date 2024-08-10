using SharedMomentsBackend.App.Models.Entities;

namespace SharedMomentsBackend.App.Services.Interfaces
{
    public interface IResourceManager
    {
        Task<Resource> UploadFile(Stream stream, string folderPath, string contentType, string name, string extension);

        Task<Stream> DownloadFile(string folderPath, string fileName, string extension);

        Task DeleteFile(string folderPath, string name, string extension);
    }
}

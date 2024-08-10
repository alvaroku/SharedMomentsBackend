using Google.Apis.Auth.OAuth2;
using Google.Cloud.Storage.V1;
using SharedMomentsBackend.App.Models.Entities;
using SharedMomentsBackend.App.Services.Interfaces;

namespace SharedMomentsBackend.App.Services.Implementations
{
    public class ResourceManager : IResourceManager
    {
        private readonly IConfiguration _configuration;
        public ResourceManager(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<Stream> DownloadFile(string folderPath, string fileName, string extension)
        {
            GoogleCredential firebaseCredential = await GoogleCredential.FromFileAsync("../SharedMomentsBackend/firebaseConfig.json", new CancellationToken());

            StorageClient storage = StorageClient.Create(firebaseCredential);

            MemoryStream memoryStream = new MemoryStream();
            await storage.DownloadObjectAsync(_configuration["Firebase:BucketStorage"], $"{folderPath}/{fileName}{extension}", memoryStream);

            memoryStream.Position = 0;
            return memoryStream;
        }

        public async Task<Resource> UploadFile(Stream stream, string folderPath, string contentType, string name, string extension)
        {

            GoogleCredential firebaseCredential = await GoogleCredential.FromFileAsync("../SharedMomentsBackend/firebaseConfig.json", new CancellationToken());

            StorageClient storage = StorageClient.Create(firebaseCredential);

            Google.Apis.Storage.v1.Data.Object result =
                await storage.UploadObjectAsync(_configuration["Firebase:BucketStorage"], $"{folderPath}/{name}{extension}", contentType, stream);

            return new Resource
            {
                Name = name,
                Url = result.MediaLink,
                Size = result.Size.GetValueOrDefault(),
                Path = $"{folderPath}",
                Extension = extension
            };
        }
        public async Task DeleteFile(string folderPath, string name, string extension)
        {
            GoogleCredential firebaseCredential = await GoogleCredential.FromFileAsync("../SharedMomentsBackend/firebaseConfig.json", new CancellationToken());
            StorageClient storage = StorageClient.Create(firebaseCredential);
            await storage.DeleteObjectAsync(_configuration["Firebase:BucketStorage"], $"{folderPath}/{name}{extension}");
        }
    }
}

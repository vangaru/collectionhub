using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace CollectionHub.CloudStorage
{
    public interface ICloudStorage
    {
        Task<string> UploadFileAsync(IFormFile imageFile, string fileNameForStorage);
        Task DeleteFileAsync(string fileNameForStorage);
    }
}
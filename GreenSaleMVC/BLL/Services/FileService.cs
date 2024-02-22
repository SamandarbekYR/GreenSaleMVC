using GreenSaleMVC.BLL.Interfaces;
using Microsoft.AspNetCore.Hosting;

namespace GreenSaleMVC.BLL.Services
{
    public class FileService(IWebHostEnvironment webHostEnvironment) : IFileService
    {
        private readonly IWebHostEnvironment _webHostEnvironment = webHostEnvironment;

        public async ValueTask DeleteImage(string fileName)
        {
            var wwwrootFolder = _webHostEnvironment.WebRootPath;
            var filePath = Path.Combine(wwwrootFolder, fileName.Replace("~/", ""));

            if (File.Exists(filePath))
            {
                await Task.Run(() => File.Delete(filePath));
            }
        }

        public async ValueTask<string> UploadImage(IFormFile file)
        {
            var wwwrootFolder = _webHostEnvironment.WebRootPath;
            var uniqueFileName = Guid.NewGuid().ToString() + "_" + file.FileName;
            var filePath = Path.Combine(wwwrootFolder, "images", uniqueFileName);

            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }

            return $"~/images/{uniqueFileName}";
        }

    }
}

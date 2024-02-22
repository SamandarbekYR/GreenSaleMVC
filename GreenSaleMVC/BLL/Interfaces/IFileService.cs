namespace GreenSaleMVC.BLL.Interfaces
{
    public interface IFileService
    {
        ValueTask<string> UploadImage(IFormFile file);
        ValueTask DeleteImage(string fileName);
    }
}
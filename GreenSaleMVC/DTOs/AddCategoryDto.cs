namespace GreenSaleMVC.DTOs
{
    public class AddCategoryDto
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public IFormFile Image { get; set; } 

    }
}

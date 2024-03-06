using GreenSaleMVC.Data.Entities.Buyers;
using GreenSaleMVC.Data.Entities.Sellers;
using GreenSaleMVC.Data.Entities.Storages;
using System.ComponentModel.DataAnnotations.Schema;

namespace GreenSaleMVC.DTOs.Category;

public class AddCategoryDto
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string ImagePath { get; set; } = string.Empty;
}

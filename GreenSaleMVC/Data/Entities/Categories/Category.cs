using GreenSaleMVC.Data.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GreenSaleMVC.Data.Entities.Categories
{
    [Table("category")]
    public class Category : Auditable
    {
        [Column("name")]
        public string Name { get; set; } = string.Empty;
        [Column("description")]
        public string Description { get; set; } = string.Empty;
        [Column("image_path")]
        public string ImagePath { get; set; } = string.Empty;
    }
}

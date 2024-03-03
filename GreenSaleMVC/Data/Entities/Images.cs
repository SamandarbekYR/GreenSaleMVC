using System.ComponentModel.DataAnnotations.Schema;

namespace GreenSaleMVC.Data.Entities
{
    public abstract class Images : Auditable
    {
        [Column("image_path")]
        public string ImagePath { get; set; } = string.Empty;
    }
}

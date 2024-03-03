using System.ComponentModel.DataAnnotations.Schema;

namespace GreenSaleMVC.Data.Entities.Storages
{
    [Table("storage_images")]
    public class StorageImages : Images
    {
        [Column("storage_id")]
        public Guid StorageId { get; set; }
        public StoragePost StoragePost { get; set; } = new();
    }
}

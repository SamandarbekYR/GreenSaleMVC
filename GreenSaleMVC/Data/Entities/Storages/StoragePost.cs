using System.ComponentModel.DataAnnotations.Schema;

namespace GreenSaleMVC.Data.Entities.Storages
{
    [Table("storage_post")]
    public class StoragePost : Post
    {
        public ICollection<StorageImages> StorageImages { get; set; } = new List<StorageImages>();
    }
}

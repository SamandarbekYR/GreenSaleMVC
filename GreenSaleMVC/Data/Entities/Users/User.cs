using System.ComponentModel.DataAnnotations.Schema;
using GreenSaleMVC.Data.Entities;
using GreenSaleMVC.Data.Entities.Buyers;
using GreenSaleMVC.Data.Entities.Sellers;
using GreenSaleMVC.Data.Entities.Storages;

namespace GreenSaleMVC.Data.Entities.Users
{
    [Table("users")]
    public class User : Auditable
    {
        [Column("name")]
        public string Name { get; set; } = string.Empty;
        [Column("email")]
        public string Email { get; set; } = string.Empty;
        [Column("phone_number")]
        public string PhoneNumber { get; set; } = string.Empty;
        [Column("image_path")]
        public string ImagePath { get; set; } = string.Empty;
        [Column("user_role_id")]
        public Guid UserRoleId { get; set; }
        public UserRole UsersRole { get; set; } = new();

        public ICollection<BuyerPost> BuyerPosts { get; set; } = new List<BuyerPost>();
        public ICollection<SellerPost> SellerPosts { get; set; } = new List<SellerPost>();
        public ICollection<StoragePost> StoragePosts { get; set; } = new List<StoragePost>();
    }
}

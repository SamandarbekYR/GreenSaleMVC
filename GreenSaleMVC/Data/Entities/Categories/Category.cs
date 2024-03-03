using GreenSaleMVC.Data.Entities;
using GreenSaleMVC.Data.Entities.Buyers;
using GreenSaleMVC.Data.Entities.Sellers;
using GreenSaleMVC.Data.Entities.Storages;
using Microsoft.Identity.Client.Extensions.Msal;
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
        public ICollection<BuyerPost> BuyerPosts { get; set; } = new List<BuyerPost>();
        public ICollection<SellerPost> SellerPosts { get; set; } = new List<SellerPost>();
        public ICollection<StoragePost> StoragePosts { get; set; } = new List<StoragePost>();
    }
}

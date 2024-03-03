using GreenSaleMVC.Data.Entities.Categories;
using GreenSaleMVC.Data.Entities.Users;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace GreenSaleMVC.Data.Entities
{
    public abstract class Post : Auditable
    {
        [Column("user_id")]
        public Guid UserId { get; set; } = new();
        public User User { get; set; } = new();
        [Column("category_id")]
        public Guid CategoryId { get; set; } = new();
        public Category Category { get; set; } = new();
        [Column("title")]
        public string Title { get; set; } = string.Empty;

        [Column("description")]
        public string Info { get; set; } = string.Empty;
        [Column("region")]
        public string Region { get; set; } = string.Empty;
        [Column("district")]
        public string District { get; set; } = string.Empty;
        [Column("lattitude")]
        public string Lattitude { get; set; } = string.Empty;
        [Column("longitude")]
        public string Longitude { get; set; } = string.Empty;
        [Column("phone_number")]
        public string PhoneNumber { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
    }
}

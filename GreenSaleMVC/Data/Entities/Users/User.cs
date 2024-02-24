using System.ComponentModel.DataAnnotations.Schema;
using GreenSaleMVC.Data.Entities;

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
        public UserRole UsersRole { get; set; }


    }
}

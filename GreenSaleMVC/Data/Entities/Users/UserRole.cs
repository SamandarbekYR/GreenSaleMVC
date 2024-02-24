
using GreenSaleMVC.Data.Entities;
using GreenSaleMVC.Data.Entities.Users;
using System.ComponentModel.DataAnnotations.Schema;

[Table("user_role")]
public class UserRole : Auditable
{
    [Column("name")]
    public string Name { get; set; } = string.Empty;
    public List<User> Users { get; set; } = new List<User>();
}

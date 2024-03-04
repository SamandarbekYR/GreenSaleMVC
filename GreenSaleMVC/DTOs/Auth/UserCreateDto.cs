using GreenSaleMVC.Data.Entities.Users;
using System.ComponentModel.DataAnnotations.Schema;

namespace GreenSaleMVC.DTOs.Auth;

public class UserCreateDto
{
    public Guid UserRoleId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public IFormFile ImagePath { get; set; } 
}

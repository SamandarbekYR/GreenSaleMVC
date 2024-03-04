namespace GreenSaleMVC.DTOs.Auth
{
    public class LogInDto
    {
        public string PhoneNumber { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public bool RememberMe { get; set; }
        public string Error { get; set; } = string.Empty;
    }
}

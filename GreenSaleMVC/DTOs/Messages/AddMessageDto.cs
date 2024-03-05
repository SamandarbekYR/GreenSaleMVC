using System.ComponentModel.DataAnnotations.Schema;

namespace GreenSaleMVC.DTOs.Messages
{
    public class AddMessageDto
    {
        public string FI { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Letter { get; set; } = string.Empty;
    }
}

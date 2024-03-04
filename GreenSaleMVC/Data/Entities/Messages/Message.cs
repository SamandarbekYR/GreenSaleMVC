using System.ComponentModel.DataAnnotations.Schema;

namespace GreenSaleMVC.Data.Entities.Messages
{
    [Table("messages")]
    public class Message : BaseEntity
    {
        [Column("fi")]
        public string FI { get; set; } = string.Empty;
        [Column("phone_number")]
        public string PhoneNumber { get; set; } = string.Empty;
        [Column("title")]
        public string Title { get; set; } = string.Empty;
        [Column("letter")]
        public string Letter { get; set; } = string.Empty;
    }
}

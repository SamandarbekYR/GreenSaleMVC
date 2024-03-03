using System.ComponentModel.DataAnnotations.Schema;

namespace GreenSaleMVC.Data.Entities.Buyers
{
    [Table("buyer_images")]
    public class BuyerPostImages : Images
    {
        [Column("buyer_id")]
        public Guid BuyerPostId { get; set; }
        public BuyerPost BuyerPost { get; set; } = new();
    }
}

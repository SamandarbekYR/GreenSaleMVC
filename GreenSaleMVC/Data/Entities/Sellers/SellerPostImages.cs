using System.ComponentModel.DataAnnotations.Schema;

namespace GreenSaleMVC.Data.Entities.Sellers
{
    [Table("seller_images")]
    public class SellerPostImages : Images
    {
        [Column("seller_id")]
        public Guid SellerId { get; set; }
        public SellerPost SellerPost { get; set; } = new();
    }
}

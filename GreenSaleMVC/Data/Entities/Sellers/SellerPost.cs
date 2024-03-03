using System.ComponentModel.DataAnnotations.Schema;

namespace GreenSaleMVC.Data.Entities.Sellers
{
    [Table("seller_post")]
    public class SellerPost : PersonPost
    {
        public ICollection<SellerPostImages> SellerPostImages { get; set; } = new List<SellerPostImages>();
    }
}

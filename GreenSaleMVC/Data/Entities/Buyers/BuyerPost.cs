using System.ComponentModel.DataAnnotations.Schema;

namespace GreenSaleMVC.Data.Entities.Buyers
{
    [Table("buyer_post")]
    public class BuyerPost : PersonPost
    {
        public ICollection<BuyerPostImages> BuyerPostImages { get; set; } = new List<BuyerPostImages>();
    }
}

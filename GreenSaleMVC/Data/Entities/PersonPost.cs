using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace GreenSaleMVC.Data.Entities
{
    public abstract class PersonPost : Post
    {
        [Column("price")]
        public double Price { get; set; }
        [Column("capacity")]
        public double Capacity { get; set; }
        [Column("capacity_measure")]
        public string CapacityMeasure { get; set; } = string.Empty;
    }
}

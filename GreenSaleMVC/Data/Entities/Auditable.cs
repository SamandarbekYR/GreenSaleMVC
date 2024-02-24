namespace GreenSaleMVC.Data.Entities;
using System.ComponentModel.DataAnnotations.Schema;

public abstract class Auditable : BaseEntity
{
    [Column("created_at")]
    public DateTime CreatedAt { get; set; }
    [Column("updated_at")]
    public DateTime UpdatedAt { get; set; }
}

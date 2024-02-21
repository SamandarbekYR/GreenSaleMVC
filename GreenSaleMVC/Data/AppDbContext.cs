using GreenSaleMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace GreenSaleMVC.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    }
}

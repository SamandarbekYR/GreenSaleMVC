using GreenSaleMVC.Data.Entities.Categories;
using GreenSaleMVC.Data.Entities.Users;
using Microsoft.EntityFrameworkCore;

namespace GreenSaleMVC.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UsersRoles { get; set; }
    }
}

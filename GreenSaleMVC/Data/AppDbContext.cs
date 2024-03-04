using GreenSaleMVC.Data.Entities.Buyers;
using GreenSaleMVC.Data.Entities.Categories;
using GreenSaleMVC.Data.Entities.Sellers;
using GreenSaleMVC.Data.Entities.Storages;
using GreenSaleMVC.Data.Entities.Users;
using Microsoft.EntityFrameworkCore;

namespace GreenSaleMVC.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UsersRoles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserRole>(entities =>
            {
                UserRole userRole = new UserRole()
                {
                    Id = Guid.Parse("6fb7cf2e-0c28-45ec-8558-4fdd0cbc59fb"),
                    Name = "SuperAdmin",
                    CreatedAt = DateTime.UtcNow.AddHours(5),
                    UpdatedAt = DateTime.UtcNow.AddHours(5)
                };

                entities.HasData(userRole);
            });

            // User Relationship
            modelBuilder.Entity<User>(entity =>
            {
                User user = new User();
                user.Id = Guid.NewGuid();
                user.Name = "Samandarbek";
                user.Email = "SamandarbekYR@gmail.com";
                user.PhoneNumber = "+998500727879";
                user.CreatedAt = DateTime.UtcNow.AddHours(5);
                user.UpdatedAt = DateTime.UtcNow.AddHours(5);
                user.UserRoleId = Guid.Parse("6fb7cf2e-0c28-45ec-8558-4fdd0cbc59fb");
                user.UsersRole = null;

                entity.HasData(user);
                
                entity.HasOne(u => u.UsersRole)
                      .WithMany(u => u.Users)
                      .HasForeignKey(u => u.UserRoleId)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            // Buyer Relationship
            modelBuilder.Entity<BuyerPost>(entity =>
            {
                entity.HasOne(bp => bp.Category)
                      .WithMany(c => c.BuyerPosts)
                      .HasForeignKey(bp => bp.CategoryId)
                      .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(bp => bp.User)
                      .WithMany(u => u.BuyerPosts)
                      .HasForeignKey(u => u.UserId)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<BuyerPostImages>(entity =>
            {
                entity.HasOne(bpi => bpi.BuyerPost)
                      .WithMany(bp => bp.BuyerPostImages)
                      .HasForeignKey(bpi => bpi.BuyerPostId)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            // Seller Relationship
            modelBuilder.Entity<SellerPost>(entity =>
            {
                entity.HasOne(sp => sp.Category)
                      .WithMany(c => c.SellerPosts)
                      .HasForeignKey(sp => sp.CategoryId)
                      .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(sp => sp.User)
                      .WithMany(u => u.SellerPosts)
                      .HasForeignKey(u => u.UserId)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<SellerPostImages>(entity =>
            {
                entity.HasOne(spi => spi.SellerPost)
                      .WithMany(sp => sp.SellerPostImages)
                      .HasForeignKey(spi => spi.SellerId)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            // Storage Relationship
            modelBuilder.Entity<StoragePost>(entity =>
            {
                entity.HasOne(sp => sp.Category)
                      .WithMany(c => c.StoragePosts)
                      .HasForeignKey(sp => sp.CategoryId)
                      .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(bp => bp.User)
                      .WithMany(u => u.StoragePosts)
                      .HasForeignKey(u => u.UserId)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<StorageImages>(entity =>
            {
                entity.HasOne(si => si.StoragePost)
                      .WithMany(sp => sp.StorageImages)
                      .HasForeignKey(si => si.StorageId)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}

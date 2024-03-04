﻿// <auto-generated />
using System;
using GreenSaleMVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GreenSaleMVC.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240303115444_createPassword")]
    partial class createPassword
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GreenSaleMVC.Data.Entities.Buyers.BuyerPost", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<double>("Capacity")
                        .HasColumnType("float")
                        .HasColumnName("capacity");

                    b.Property<string>("CapacityMeasure")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("capacity_measure");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("category_id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("district");

                    b.Property<string>("Info")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("description");

                    b.Property<string>("Lattitude")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("lattitude");

                    b.Property<string>("Longitude")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("longitude");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("phone_number");

                    b.Property<double>("Price")
                        .HasColumnType("float")
                        .HasColumnName("price");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("region");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("title");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("updated_at");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("buyer_post");
                });

            modelBuilder.Entity("GreenSaleMVC.Data.Entities.Buyers.BuyerPostImages", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<Guid>("BuyerPostId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("buyer_id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("image_path");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.HasIndex("BuyerPostId");

                    b.ToTable("buyer_images");
                });

            modelBuilder.Entity("GreenSaleMVC.Data.Entities.Categories.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("description");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("image_path");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.ToTable("category");
                });

            modelBuilder.Entity("GreenSaleMVC.Data.Entities.Sellers.SellerPost", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<double>("Capacity")
                        .HasColumnType("float")
                        .HasColumnName("capacity");

                    b.Property<string>("CapacityMeasure")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("capacity_measure");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("category_id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("district");

                    b.Property<string>("Info")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("description");

                    b.Property<string>("Lattitude")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("lattitude");

                    b.Property<string>("Longitude")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("longitude");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("phone_number");

                    b.Property<double>("Price")
                        .HasColumnType("float")
                        .HasColumnName("price");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("region");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("title");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("updated_at");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("seller_post");
                });

            modelBuilder.Entity("GreenSaleMVC.Data.Entities.Sellers.SellerPostImages", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("image_path");

                    b.Property<Guid>("SellerId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("seller_id");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.HasIndex("SellerId");

                    b.ToTable("seller_images");
                });

            modelBuilder.Entity("GreenSaleMVC.Data.Entities.Storages.StorageImages", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("image_path");

                    b.Property<Guid>("StorageId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("storage_id");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.HasIndex("StorageId");

                    b.ToTable("storage_images");
                });

            modelBuilder.Entity("GreenSaleMVC.Data.Entities.Storages.StoragePost", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("category_id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("district");

                    b.Property<string>("Info")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("description");

                    b.Property<string>("Lattitude")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("lattitude");

                    b.Property<string>("Longitude")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("longitude");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("phone_number");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("region");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("title");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("updated_at");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("storage_post");
                });

            modelBuilder.Entity("GreenSaleMVC.Data.Entities.Users.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("email");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("image_path");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("password_hash");

                    b.Property<string>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("password_salt");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("phone_number");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("updated_at");

                    b.Property<Guid>("UserRoleId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("user_role_id");

                    b.HasKey("Id");

                    b.HasIndex("UserRoleId");

                    b.ToTable("users");
                });

            modelBuilder.Entity("GreenSaleMVC.Data.Entities.Users.UserRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.ToTable("user_role");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6fb7cf2e-0c28-45ec-8558-4fdd0cbc59fb"),
                            CreatedAt = new DateTime(2024, 3, 3, 16, 54, 44, 321, DateTimeKind.Utc).AddTicks(4895),
                            Name = "SuperAdmin",
                            UpdatedAt = new DateTime(2024, 3, 3, 16, 54, 44, 321, DateTimeKind.Utc).AddTicks(4904)
                        });
                });

            modelBuilder.Entity("GreenSaleMVC.Data.Entities.Buyers.BuyerPost", b =>
                {
                    b.HasOne("GreenSaleMVC.Data.Entities.Categories.Category", "Category")
                        .WithMany("BuyerPosts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GreenSaleMVC.Data.Entities.Users.User", "User")
                        .WithMany("BuyerPosts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("User");
                });

            modelBuilder.Entity("GreenSaleMVC.Data.Entities.Buyers.BuyerPostImages", b =>
                {
                    b.HasOne("GreenSaleMVC.Data.Entities.Buyers.BuyerPost", "BuyerPost")
                        .WithMany("BuyerPostImages")
                        .HasForeignKey("BuyerPostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BuyerPost");
                });

            modelBuilder.Entity("GreenSaleMVC.Data.Entities.Sellers.SellerPost", b =>
                {
                    b.HasOne("GreenSaleMVC.Data.Entities.Categories.Category", "Category")
                        .WithMany("SellerPosts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GreenSaleMVC.Data.Entities.Users.User", "User")
                        .WithMany("SellerPosts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("User");
                });

            modelBuilder.Entity("GreenSaleMVC.Data.Entities.Sellers.SellerPostImages", b =>
                {
                    b.HasOne("GreenSaleMVC.Data.Entities.Sellers.SellerPost", "SellerPost")
                        .WithMany("SellerPostImages")
                        .HasForeignKey("SellerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SellerPost");
                });

            modelBuilder.Entity("GreenSaleMVC.Data.Entities.Storages.StorageImages", b =>
                {
                    b.HasOne("GreenSaleMVC.Data.Entities.Storages.StoragePost", "StoragePost")
                        .WithMany("StorageImages")
                        .HasForeignKey("StorageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StoragePost");
                });

            modelBuilder.Entity("GreenSaleMVC.Data.Entities.Storages.StoragePost", b =>
                {
                    b.HasOne("GreenSaleMVC.Data.Entities.Categories.Category", "Category")
                        .WithMany("StoragePosts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GreenSaleMVC.Data.Entities.Users.User", "User")
                        .WithMany("StoragePosts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("User");
                });

            modelBuilder.Entity("GreenSaleMVC.Data.Entities.Users.User", b =>
                {
                    b.HasOne("GreenSaleMVC.Data.Entities.Users.UserRole", "UsersRole")
                        .WithMany("Users")
                        .HasForeignKey("UserRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UsersRole");
                });

            modelBuilder.Entity("GreenSaleMVC.Data.Entities.Buyers.BuyerPost", b =>
                {
                    b.Navigation("BuyerPostImages");
                });

            modelBuilder.Entity("GreenSaleMVC.Data.Entities.Categories.Category", b =>
                {
                    b.Navigation("BuyerPosts");

                    b.Navigation("SellerPosts");

                    b.Navigation("StoragePosts");
                });

            modelBuilder.Entity("GreenSaleMVC.Data.Entities.Sellers.SellerPost", b =>
                {
                    b.Navigation("SellerPostImages");
                });

            modelBuilder.Entity("GreenSaleMVC.Data.Entities.Storages.StoragePost", b =>
                {
                    b.Navigation("StorageImages");
                });

            modelBuilder.Entity("GreenSaleMVC.Data.Entities.Users.User", b =>
                {
                    b.Navigation("BuyerPosts");

                    b.Navigation("SellerPosts");

                    b.Navigation("StoragePosts");
                });

            modelBuilder.Entity("GreenSaleMVC.Data.Entities.Users.UserRole", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
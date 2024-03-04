using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GreenSaleMVC.Migrations
{
    /// <inheritdoc />
    public partial class usercreatead : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "user_role",
                keyColumn: "id",
                keyValue: new Guid("6fb7cf2e-0c28-45ec-8558-4fdd0cbc59fb"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 3, 3, 17, 21, 48, 439, DateTimeKind.Utc).AddTicks(9129), new DateTime(2024, 3, 3, 17, 21, 48, 439, DateTimeKind.Utc).AddTicks(9138) });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "id", "created_at", "email", "image_path", "name", "password_hash", "password_salt", "phone_number", "updated_at", "user_role_id" },
                values: new object[] { new Guid("fb51c596-ffd4-46d0-82fd-50e3dda0d41a"), new DateTime(2024, 3, 3, 17, 21, 48, 439, DateTimeKind.Utc).AddTicks(9371), "SamandarbekYR@gmail.com", "", "Samandarbek", "", "", "+998500727879", new DateTime(2024, 3, 3, 17, 21, 48, 439, DateTimeKind.Utc).AddTicks(9372), new Guid("6fb7cf2e-0c28-45ec-8558-4fdd0cbc59fb") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("fb51c596-ffd4-46d0-82fd-50e3dda0d41a"));

            migrationBuilder.UpdateData(
                table: "user_role",
                keyColumn: "id",
                keyValue: new Guid("6fb7cf2e-0c28-45ec-8558-4fdd0cbc59fb"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 3, 3, 16, 54, 44, 321, DateTimeKind.Utc).AddTicks(4895), new DateTime(2024, 3, 3, 16, 54, 44, 321, DateTimeKind.Utc).AddTicks(4904) });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GreenSaleMVC.Migrations
{
    /// <inheritdoc />
    public partial class createPassword : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "user_role",
                keyColumn: "id",
                keyValue: new Guid("b5233efe-ab17-4f71-888e-f2e54296149f"));

            migrationBuilder.AddColumn<string>(
                name: "password_hash",
                table: "users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "password_salt",
                table: "users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "user_role",
                columns: new[] { "id", "created_at", "name", "updated_at" },
                values: new object[] { new Guid("6fb7cf2e-0c28-45ec-8558-4fdd0cbc59fb"), new DateTime(2024, 3, 3, 16, 54, 44, 321, DateTimeKind.Utc).AddTicks(4895), "SuperAdmin", new DateTime(2024, 3, 3, 16, 54, 44, 321, DateTimeKind.Utc).AddTicks(4904) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "user_role",
                keyColumn: "id",
                keyValue: new Guid("6fb7cf2e-0c28-45ec-8558-4fdd0cbc59fb"));

            migrationBuilder.DropColumn(
                name: "password_hash",
                table: "users");

            migrationBuilder.DropColumn(
                name: "password_salt",
                table: "users");

            migrationBuilder.InsertData(
                table: "user_role",
                columns: new[] { "id", "created_at", "name", "updated_at" },
                values: new object[] { new Guid("b5233efe-ab17-4f71-888e-f2e54296149f"), new DateTime(2024, 3, 3, 16, 50, 22, 905, DateTimeKind.Utc).AddTicks(1482), "Admin", new DateTime(2024, 3, 3, 16, 50, 22, 905, DateTimeKind.Utc).AddTicks(1489) });
        }
    }
}

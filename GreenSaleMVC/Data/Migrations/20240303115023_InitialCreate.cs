using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GreenSaleMVC.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "user_role",
                columns: new[] { "id", "created_at", "name", "updated_at" },
                values: new object[] { new Guid("b5233efe-ab17-4f71-888e-f2e54296149f"), new DateTime(2024, 3, 3, 16, 50, 22, 905, DateTimeKind.Utc).AddTicks(1482), "Admin", new DateTime(2024, 3, 3, 16, 50, 22, 905, DateTimeKind.Utc).AddTicks(1489) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "user_role",
                keyColumn: "id",
                keyValue: new Guid("b5233efe-ab17-4f71-888e-f2e54296149f"));
        }
    }
}

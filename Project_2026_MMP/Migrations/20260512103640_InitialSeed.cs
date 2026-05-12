using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project_2026_MMP.Migrations
{
    /// <inheritdoc />
    public partial class InitialSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "11111111-ffff-ffff-ffff-ffffffffffff", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "00000000-ffff-ffff-ffff-ffffffffffff", 0, "022f6513-5766-41f7-911a-73b3a4451aca", "admin@flowershop.pl", true, false, null, "ADMIN@FLOWERSHOP.PL", "ADMIN@FLOWERSHOP.PL", "AQAAAAIAAYagAAAAED9GbfmmG3uqc99O2v4sULwrZdsalUzzdNcBB5W/YQeZ/Mn6hCNnfLlOPeq9dqp5Jg==", null, false, "d25739f2-4d83-4464-8d6a-5445d3f8bd60", false, "admin@flowershop.pl" });

            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[] { 1, "position", "Admin", "00000000-ffff-ffff-ffff-ffffffffffff" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "11111111-ffff-ffff-ffff-ffffffffffff", "00000000-ffff-ffff-ffff-ffffffffffff" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "11111111-ffff-ffff-ffff-ffffffffffff", "00000000-ffff-ffff-ffff-ffffffffffff" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11111111-ffff-ffff-ffff-ffffffffffff");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff");
        }
    }
}

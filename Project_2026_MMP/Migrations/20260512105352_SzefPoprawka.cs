using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project_2026_MMP.Migrations
{
    /// <inheritdoc />
    public partial class SzefPoprawka : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "926BDC2F-0074-4B27-97BB-1696587B804F", "SZTYWNY_STAMP_ROLI_123", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "22222222-ffff-ffff-ffff-ffffffffffff", 0, "SZTYWNY_STAMP_SZEFA_123", "szef@flowershop.pl", true, false, null, "SZEF@FLOWERSHOP.PL", "SZEF@FLOWERSHOP.PL", "AQAAAAIAAYagAAAAEKKPdmOXA0Zpx5iE7fjtSl9hEedtzwcXWStqJFUV5WCTbXtaBe3EloTWYheYA/CBDa==", null, false, "TAJNY_STAMP_NOWEGO_SZEFA_123", false, "szef@flowershop.pl" });

            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[] { 2, "position", "Admin", "22222222-ffff-ffff-ffff-ffffffffffff" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "926BDC2F-0074-4B27-97BB-1696587B804F", "22222222-ffff-ffff-ffff-ffffffffffff" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "926BDC2F-0074-4B27-97BB-1696587B804F", "22222222-ffff-ffff-ffff-ffffffffffff" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "926BDC2F-0074-4B27-97BB-1696587B804F");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22222222-ffff-ffff-ffff-ffffffffffff");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "11111111-ffff-ffff-ffff-ffffffffffff", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "00000000-ffff-ffff-ffff-ffffffffffff", 0, "1bbb73d9-6f8e-45bf-86a7-191df7f423cc", "admin@flowershop.pl", true, false, null, "ADMIN@FLOWERSHOP.PL", "ADMIN@FLOWERSHOP.PL", "AQAAAAIAAYagAAAAEChnLDB0tHz8r/kXQg9/GUQPdMSl79Q6RGZnVQr67kk38XxruEZ74rab9rPdGLeZkA==", null, false, "bb8ea444-8945-40b5-947a-eb7aef78d1de", false, "admin@flowershop.pl" });

            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[] { 1, "position", "Admin", "00000000-ffff-ffff-ffff-ffffffffffff" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "11111111-ffff-ffff-ffff-ffffffffffff", "00000000-ffff-ffff-ffff-ffffffffffff" });
        }
    }
}

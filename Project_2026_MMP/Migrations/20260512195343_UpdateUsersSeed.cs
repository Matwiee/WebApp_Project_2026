using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project_2026_MMP.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUsersSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "11111111-ffff-ffff-ffff-ffffffffffff", "22222222-ffff-ffff-ffff-ffffffffffff" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11111111-ffff-ffff-ffff-ffffffffffff");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22222222-ffff-ffff-ffff-ffffffffffff");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ClaimType", "ClaimValue", "UserId" },
                values: new object[] { "Position", "Cashier", "22222222-2222-2222-2222-222222222222" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "11111111-1111-1111-1111-111111111111", 0, "e5101572-d8ab-4b6e-af28-e3e9080cd157", "admin@flowershop.pl", true, false, null, "ADMIN@FLOWERSHOP.PL", "ADMIN@FLOWERSHOP.PL", "AQAAAAIAAYagAAAAELZKV5DTsIhJHyHa+PvlHGs+hOv0KPB//JwVloIrm7E4+KVCn5SwXWjrhLHIZKv4Pw==", null, false, "STALY_STAMP_ADMIN_123", false, "admin@flowershop.pl" },
                    { "22222222-2222-2222-2222-222222222222", 0, "363be7ce-50ec-4194-bb55-3efc3ce5efbf", "cashier@flowershop.pl", true, false, null, "CASHIER@FLOWERSHOP.PL", "CASHIER@FLOWERSHOP.PL", "AQAAAAIAAYagAAAAEEdiEJsdsrPHUcx8+VWo7KN4/1IiIE6zH7s1N4MZZqxDfl4GwG0WSANIbCBpd6BgAQ==", null, false, "STALY_STAMP_CASHIER_123", false, "cashier@flowershop.pl" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[] { 1, "Position", "Admin", "11111111-1111-1111-1111-111111111111" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22222222-2222-2222-2222-222222222222");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "11111111-ffff-ffff-ffff-ffffffffffff", "SZTYWNY_STAMP_ROLI_123", "Admin", "ADMIN" });

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ClaimType", "ClaimValue", "UserId" },
                values: new object[] { "position", "Admin", "22222222-ffff-ffff-ffff-ffffffffffff" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "22222222-ffff-ffff-ffff-ffffffffffff", 0, "SZTYWNY_STAMP_SZEFA_123", "szef@flowershop.pl", true, false, null, "SZEF@FLOWERSHOP.PL", "SZEF@FLOWERSHOP.PL", "AQAAAAIAAYagAAAAEKKPdmOXA0Zpx5iE7fjtSl9hEedtzwcXWStqJFUV5WCTbXtaBe3EloTWYheYA/CBDa==", null, false, "TAJNY_STAMP_NOWEGO_SZEFA_123", false, "szef@flowershop.pl" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "11111111-ffff-ffff-ffff-ffffffffffff", "22222222-ffff-ffff-ffff-ffffffffffff" });
        }
    }
}

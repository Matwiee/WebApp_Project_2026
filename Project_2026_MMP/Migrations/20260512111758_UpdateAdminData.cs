using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project_2026_MMP.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAdminData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "926BDC2F-0074-4B27-97BB-1696587B804F", "22222222-ffff-ffff-ffff-ffffffffffff" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "926BDC2F-0074-4B27-97BB-1696587B804F");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "11111111-ffff-ffff-ffff-ffffffffffff", "SZTYWNY_STAMP_ROLI_123", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "11111111-ffff-ffff-ffff-ffffffffffff", "22222222-ffff-ffff-ffff-ffffffffffff" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "11111111-ffff-ffff-ffff-ffffffffffff", "22222222-ffff-ffff-ffff-ffffffffffff" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11111111-ffff-ffff-ffff-ffffffffffff");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "926BDC2F-0074-4B27-97BB-1696587B804F", "SZTYWNY_STAMP_ROLI_123", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "926BDC2F-0074-4B27-97BB-1696587B804F", "22222222-ffff-ffff-ffff-ffffffffffff" });
        }
    }
}

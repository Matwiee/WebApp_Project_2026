using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project_2026_MMP.Migrations
{
    /// <inheritdoc />
    public partial class SeedInitialUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8b874c45-162e-4a41-a7e7-e158b431261d", "AQAAAAIAAYagAAAAEHRCtUZmoRPZ28v/AbX5+rrcMJwBYvP9D3b+vQDFgtJ2vlXbSZGVnHLnwTJPVOgSdA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22222222-2222-2222-2222-222222222222",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4daa9a8d-371b-4964-9997-109d27e4a5cd", "AQAAAAIAAYagAAAAEJb0vV5dQsmBvFalcpIk3z5lksSzBtFZxajyoFtfjymY4/uCyqqxSRupUFfG75khGA==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e5101572-d8ab-4b6e-af28-e3e9080cd157", "AQAAAAIAAYagAAAAELZKV5DTsIhJHyHa+PvlHGs+hOv0KPB//JwVloIrm7E4+KVCn5SwXWjrhLHIZKv4Pw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22222222-2222-2222-2222-222222222222",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "363be7ce-50ec-4194-bb55-3efc3ce5efbf", "AQAAAAIAAYagAAAAEEdiEJsdsrPHUcx8+VWo7KN4/1IiIE6zH7s1N4MZZqxDfl4GwG0WSANIbCBpd6BgAQ==" });
        }
    }
}

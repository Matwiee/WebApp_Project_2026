using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project_2026_MMP.Migrations
{
    /// <inheritdoc />
    public partial class SeedUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8108fc01-6a2c-486c-b3e2-c86ec40e747a", "AQAAAAIAAYagAAAAEBsnEUL77S87eWtag1hkKjTQHbVjqOAmHKwWOpLakz4xzMAaVllrm17KklfddaQE2Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22222222-2222-2222-2222-222222222222",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7921d44c-f1ef-4e83-8a24-c3ace5ace307", "AQAAAAIAAYagAAAAEJnYEGFSCNEcXgbAu2QnwCVtRp5t2Xd5oYXK6PYtlRRhL/fMp6FwZihyF3rS1EIF2w==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}

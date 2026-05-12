using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project_2026_MMP.Migrations
{
    /// <inheritdoc />
    public partial class ResetAndSeedUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[,]
                {
                    { 100, "Position", "Admin", "11111111-1111-1111-1111-111111111111" },
                    { 101, "Position", "Cashier", "22222222-2222-2222-2222-222222222222" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "30f46d80-1434-4926-a5f7-f28b625a6feb", "AQAAAAIAAYagAAAAEFT8bR6emmnRN72+9xSDQMRefjT6HZ9JfJIfOYT/pl89/xL1uRGlfE8Y6d0piciwhw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22222222-2222-2222-2222-222222222222",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "32df5e51-060f-4d34-96c5-009f96098890", "AQAAAAIAAYagAAAAECnVYVl9jDF3ZW86tOFHdXkVchhbDY1DH8fIeXp4pi//oXb1F14uoUP/81zN3971pA==", "34a5940a-e65d-47f9-a074-bab75b244096" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[,]
                {
                    { 1, "Position", "Admin", "11111111-1111-1111-1111-111111111111" },
                    { 2, "Position", "Cashier", "22222222-2222-2222-2222-222222222222" }
                });

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7921d44c-f1ef-4e83-8a24-c3ace5ace307", "AQAAAAIAAYagAAAAEJnYEGFSCNEcXgbAu2QnwCVtRp5t2Xd5oYXK6PYtlRRhL/fMp6FwZihyF3rS1EIF2w==", "STALY_STAMP_CASHIER_123" });
        }
    }
}

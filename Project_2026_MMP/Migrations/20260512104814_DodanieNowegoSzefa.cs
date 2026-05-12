using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project_2026_MMP.Migrations
{
    /// <inheritdoc />
    public partial class DodanieNowegoSzefa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1bbb73d9-6f8e-45bf-86a7-191df7f423cc", "AQAAAAIAAYagAAAAEChnLDB0tHz8r/kXQg9/GUQPdMSl79Q6RGZnVQr67kk38XxruEZ74rab9rPdGLeZkA==", "bb8ea444-8945-40b5-947a-eb7aef78d1de" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "022f6513-5766-41f7-911a-73b3a4451aca", "AQAAAAIAAYagAAAAED9GbfmmG3uqc99O2v4sULwrZdsalUzzdNcBB5W/YQeZ/Mn6hCNnfLlOPeq9dqp5Jg==", "d25739f2-4d83-4464-8d6a-5445d3f8bd60" });
        }
    }
}

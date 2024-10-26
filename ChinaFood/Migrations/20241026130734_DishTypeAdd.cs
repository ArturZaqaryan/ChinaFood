using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChinaFood.Migrations
{
    /// <inheritdoc />
    public partial class DishTypeAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DishType",
                table: "Dishes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "69d62acf-5c91-49e2-a751-796acb4a15dc", "AQAAAAIAAYagAAAAEP/O4qsENQo9a4lAR7ZaTH3u8PRddf3T2tf4Hndyi36oyB6LOvShIKIIzPIZlcEmTA==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DishType",
                table: "Dishes");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e28fd5f3-21a3-4e9c-b676-e4473df1fee4", "AQAAAAIAAYagAAAAEM6QFAgmq9sD2w1RN9xVYAVQ0I8fl48GmX2saz+d/ZLSOB/y5QRhdZ1Lhpkbb6jB7w==" });
        }
    }
}

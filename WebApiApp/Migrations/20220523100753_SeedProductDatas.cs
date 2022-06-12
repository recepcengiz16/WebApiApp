using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiApp.Migrations
{
    public partial class SeedProductDatas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImagePath",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedDate", "ImagePath", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 5, 20, 13, 7, 52, 893, DateTimeKind.Local).AddTicks(9499), null, "Bilgisayar", 15000m, 300 },
                    { 2, new DateTime(2022, 4, 23, 13, 7, 52, 893, DateTimeKind.Local).AddTicks(9538), null, "Telefon", 3750m, 400 },
                    { 3, new DateTime(2022, 5, 8, 13, 7, 52, 893, DateTimeKind.Local).AddTicks(9543), null, "Tablet", 2500m, 350 },
                    { 4, new DateTime(2022, 3, 24, 13, 7, 52, 893, DateTimeKind.Local).AddTicks(9547), null, "Akıllı Saat", 1500m, 600 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.AlterColumn<string>(
                name: "ImagePath",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiApp.Migrations
{
    public partial class reformedEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 21, 14, 59, 43, 677, DateTimeKind.Local).AddTicks(8970));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 4, 24, 14, 59, 43, 677, DateTimeKind.Local).AddTicks(8987));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 9, 14, 59, 43, 677, DateTimeKind.Local).AddTicks(8991));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 25, 14, 59, 43, 677, DateTimeKind.Local).AddTicks(8995));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 20, 19, 59, 55, 153, DateTimeKind.Local).AddTicks(4413));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 4, 23, 19, 59, 55, 153, DateTimeKind.Local).AddTicks(4448));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 8, 19, 59, 55, 153, DateTimeKind.Local).AddTicks(4451));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 24, 19, 59, 55, 153, DateTimeKind.Local).AddTicks(4455));
        }
    }
}

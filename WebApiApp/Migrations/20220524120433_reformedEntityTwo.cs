using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiApp.Migrations
{
    public partial class reformedEntityTwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 21, 15, 4, 32, 661, DateTimeKind.Local).AddTicks(3561));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 4, 24, 15, 4, 32, 661, DateTimeKind.Local).AddTicks(3584));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 9, 15, 4, 32, 661, DateTimeKind.Local).AddTicks(3589));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 25, 15, 4, 32, 661, DateTimeKind.Local).AddTicks(3595));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}

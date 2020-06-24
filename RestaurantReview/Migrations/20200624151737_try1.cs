using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RestaurantReview.Migrations
{
    public partial class try1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Creator",
                table: "Reviews",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                table: "Reviews",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReviewDate",
                value: new DateTime(2020, 6, 24, 11, 17, 36, 877, DateTimeKind.Local).AddTicks(4139));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReviewDate",
                value: new DateTime(2020, 6, 24, 11, 17, 36, 879, DateTimeKind.Local).AddTicks(2959));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReviewDate",
                value: new DateTime(2020, 6, 24, 11, 17, 36, 879, DateTimeKind.Local).AddTicks(2990));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReviewDate",
                value: new DateTime(2020, 6, 24, 11, 17, 36, 879, DateTimeKind.Local).AddTicks(2995));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "ReviewDate",
                value: new DateTime(2020, 6, 24, 11, 17, 36, 879, DateTimeKind.Local).AddTicks(2998));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "ReviewDate",
                value: new DateTime(2020, 6, 24, 11, 17, 36, 879, DateTimeKind.Local).AddTicks(3001));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "ReviewDate",
                value: new DateTime(2020, 6, 24, 11, 17, 36, 879, DateTimeKind.Local).AddTicks(3004));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "ReviewDate",
                value: new DateTime(2020, 6, 24, 11, 17, 36, 879, DateTimeKind.Local).AddTicks(3007));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "ReviewDate",
                value: new DateTime(2020, 6, 24, 11, 17, 36, 879, DateTimeKind.Local).AddTicks(3011));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Creator",
                table: "Reviews",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                table: "Reviews",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReviewDate",
                value: new DateTime(2020, 6, 19, 13, 39, 1, 536, DateTimeKind.Local).AddTicks(4933));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReviewDate",
                value: new DateTime(2020, 6, 19, 13, 39, 1, 541, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReviewDate",
                value: new DateTime(2020, 6, 19, 13, 39, 1, 541, DateTimeKind.Local).AddTicks(4233));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReviewDate",
                value: new DateTime(2020, 6, 19, 13, 39, 1, 541, DateTimeKind.Local).AddTicks(4244));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "ReviewDate",
                value: new DateTime(2020, 6, 19, 13, 39, 1, 541, DateTimeKind.Local).AddTicks(4249));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "ReviewDate",
                value: new DateTime(2020, 6, 19, 13, 39, 1, 541, DateTimeKind.Local).AddTicks(4255));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "ReviewDate",
                value: new DateTime(2020, 6, 19, 13, 39, 1, 541, DateTimeKind.Local).AddTicks(4260));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "ReviewDate",
                value: new DateTime(2020, 6, 19, 13, 39, 1, 541, DateTimeKind.Local).AddTicks(4265));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "ReviewDate",
                value: new DateTime(2020, 6, 19, 13, 39, 1, 541, DateTimeKind.Local).AddTicks(4269));
        }
    }
}

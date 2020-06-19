using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RestaurantReview.Migrations
{
    public partial class NewReviewsSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "Comment", "Creator", "RestaurantId", "ReviewDate" },
                values: new object[] { "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed est quam, ornare sit amet pretium non, posuere rhoncus dui. Curabitur gravida risus eget risus scelerisque, eu tristique velit accumsan. Nam ligula purus, sagittis sed dolor vitae, posuere accumsan purus. Donec metus velit, commodo eu viverra in, lobortis ac diam. Suspendisse lacinia mi mauris, at ultrices dolor maximus eget. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos", "Brenda", 1, new DateTime(2020, 6, 19, 13, 39, 1, 541, DateTimeKind.Local).AddTicks(4134) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Comment", "Creator", "RestaurantId", "ReviewDate" },
                values: new object[] { "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed est quam, ornare sit amet pretium non, posuere rhoncus dui. Curabitur gravida risus eget risus scelerisque, eu tristique velit accumsan. Nam ligula purus, sagittis sed dolor vitae, posuere accumsan purus. Donec metus velit, commodo eu viverra in, lobortis ac diam. Suspendisse lacinia mi mauris, at ultrices dolor maximus eget. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos", "Corey", 1, new DateTime(2020, 6, 19, 13, 39, 1, 541, DateTimeKind.Local).AddTicks(4233) });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "Creator", "RestaurantId", "ReviewDate" },
                values: new object[,]
                {
                    { 4, " Their burritos were great!", "Laurie", 2, new DateTime(2020, 6, 19, 13, 39, 1, 541, DateTimeKind.Local).AddTicks(4244) },
                    { 5, " Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed est quam, ornare sit amet pretium non, posuere rhoncus dui. Curabitur gravida risus eget risus scelerisque, eu tristique velit accumsan. Nam ligula purus, sagittis sed dolor vitae, posuere accumsan purus. Donec metus velit, commodo eu viverra in, lobortis ac diam. Suspendisse lacinia mi mauris, at ultrices dolor maximus eget. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos", "Jay", 2, new DateTime(2020, 6, 19, 13, 39, 1, 541, DateTimeKind.Local).AddTicks(4249) },
                    { 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed est quam, ornare sit amet pretium non, posuere rhoncus dui. Curabitur gravida risus eget risus scelerisque, eu tristique velit accumsan. Nam ligula purus, sagittis sed dolor vitae, posuere accumsan purus. Donec metus velit, commodo eu viverra in, lobortis ac diam. Suspendisse lacinia mi mauris, at ultrices dolor maximus eget. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos", "Josh", 2, new DateTime(2020, 6, 19, 13, 39, 1, 541, DateTimeKind.Local).AddTicks(4255) },
                    { 7, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed est quam, ornare sit amet pretium non, posuere rhoncus dui. Curabitur gravida risus eget risus scelerisque, eu tristique velit accumsan. Nam ligula purus, sagittis sed dolor vitae, posuere accumsan purus. Donec metus velit, commodo eu viverra in, lobortis ac diam. Suspendisse lacinia mi mauris, at ultrices dolor maximus eget. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos", "Corey", 3, new DateTime(2020, 6, 19, 13, 39, 1, 541, DateTimeKind.Local).AddTicks(4260) },
                    { 8, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed est quam, ornare sit amet pretium non, posuere rhoncus dui. Curabitur gravida risus eget risus scelerisque, eu tristique velit accumsan. Nam ligula purus, sagittis sed dolor vitae, posuere accumsan purus. Donec metus velit, commodo eu viverra in, lobortis ac diam. Suspendisse lacinia mi mauris, at ultrices dolor maximus eget. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos", "John", 3, new DateTime(2020, 6, 19, 13, 39, 1, 541, DateTimeKind.Local).AddTicks(4265) },
                    { 9, "The seafood here is pretty ok for Lake Erie", "Dakota", 3, new DateTime(2020, 6, 19, 13, 39, 1, 541, DateTimeKind.Local).AddTicks(4269) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReviewDate",
                value: new DateTime(2020, 6, 19, 11, 57, 21, 268, DateTimeKind.Local).AddTicks(6632));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Comment", "Creator", "RestaurantId", "ReviewDate" },
                values: new object[] { " Their burritos were great!", "Jay", 2, new DateTime(2020, 6, 19, 11, 57, 21, 276, DateTimeKind.Local).AddTicks(8773) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Comment", "Creator", "RestaurantId", "ReviewDate" },
                values: new object[] { "The seafood here is pretty ok for Lake Erie", "Dakota", 3, new DateTime(2020, 6, 19, 11, 57, 21, 276, DateTimeKind.Local).AddTicks(8872) });
        }
    }
}

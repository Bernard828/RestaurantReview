using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RestaurantReview.Migrations
{
    public partial class ReviewModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RestaurantId = table.Column<int>(nullable: false),
                    Creator = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: true),
                    ReviewDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "Creator", "RestaurantId", "ReviewDate" },
                values: new object[] { 1, " Pepporoni Pizza is awesome", "Bernard", 1, new DateTime(2020, 6, 19, 11, 57, 21, 268, DateTimeKind.Local).AddTicks(6632) });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "Creator", "RestaurantId", "ReviewDate" },
                values: new object[] { 2, " Their burritos were great!", "Jay", 2, new DateTime(2020, 6, 19, 11, 57, 21, 276, DateTimeKind.Local).AddTicks(8773) });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "Creator", "RestaurantId", "ReviewDate" },
                values: new object[] { 3, "The seafood here is pretty ok for Lake Erie", "Dakota", 3, new DateTime(2020, 6, 19, 11, 57, 21, 276, DateTimeKind.Local).AddTicks(8872) });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_RestaurantId",
                table: "Reviews",
                column: "RestaurantId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace RestaurantReview.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Restaurants",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Details = table.Column<string>(nullable: true),
                    LinkImage = table.Column<string>(nullable: true),
                    LinkUrl = table.Column<string>(nullable: true),
                    LinkDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurants", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "Details", "LinkDescription", "LinkImage", "LinkUrl", "Name" },
                values: new object[] { 1, "Great pizza place", "Donatos Image", "./images/Donatos-Pizza-restaurant-1200x900.jpg", "https://www.donatos.com", "Donato's" });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "Details", "LinkDescription", "LinkImage", "LinkUrl", "Name" },
                values: new object[] { 2, "Like chipotle but 10x better", "Agave Image", "./images/agave.jpg", "https://www.facebook.com/agaveburritobar/", "Agave" });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "Details", "LinkDescription", "LinkImage", "LinkUrl", "Name" },
                values: new object[] { 3, "Really great seafood", "Pier W Image", "./images/pierW.jpg", "http://pierw.com/", "Pier W" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Restaurants");
        }
    }
}

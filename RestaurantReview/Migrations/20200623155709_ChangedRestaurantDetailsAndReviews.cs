using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RestaurantReview.Migrations
{
    public partial class ChangedRestaurantDetailsAndReviews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1,
                column: "Details",
                value: "Donatos is a family-owned pizza company famous for Edge to Edge® toppings on a crispy golden thin crust. Founded in Columbus, Ohio in 1963, we take pride in giving back in every community we serve.");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 2,
                column: "Details",
                value: "An Oberlin staple since 2003, Agave is the spot for fresh Mexi-Cali quick-serve cuisine, exceptional margaritas and draft beer!");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 3,
                column: "Details",
                value: "Pier W is a landmark restaurant that has been Cleveland's premier destination for five-star dining, fresh seafood and fine wines since 1965.");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Comment", "ReviewDate" },
                values: new object[] { "Pepporoni Pizza is awesome. The lady at the counter was great! She tossed in some extra breadsticks because they were honoring the community that day! Thanks again Donato's i'll be back!!!", new DateTime(2020, 6, 23, 11, 57, 8, 618, DateTimeKind.Local).AddTicks(9588) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Comment", "ReviewDate" },
                values: new object[] { "Whether you are traveling thru Ohio, or you live here, you have to try Donatos Pizza!Last year, I gave up on pizza, as I found all the chains to be measly with their veggies, heavy on the salt, and not so fresh. But now that I've eaten Donatos, I've changed my mind completely. Tho I order my pizza as 'takeout', the store had a nice eating area with booths. It was very clean and tidy, and it offers salads and sides. Wholesome atmosphere.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Comment", "ReviewDate" },
                values: new object[] { "Hopefully the previous comments got this place in 5 star shape because I just ordered for the first time and it is delicious! I ordered a large create your own with well done instructions and it came early and perfectly done. Glad I gave them a chance. The delivery gal was super friendly too!", new DateTime(2020, 6, 23, 11, 57, 8, 625, DateTimeKind.Local).AddTicks(7112) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Comment", "ReviewDate" },
                values: new object[] { "We were in town from out of state and decided to stop in for dinner. Fun atmosphere, amazing food and drinks ( loved the Pink Dragon!) I would definitely come back if I’m ever in the area. The 2 people working there were very friendly and did their job well and with smiles on their faces adding to the great atmosphere!", new DateTime(2020, 6, 23, 11, 57, 8, 625, DateTimeKind.Local).AddTicks(7226) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Comment", "ReviewDate" },
                values: new object[] { "This place might have ruined Chipotle for me. The food here is so amazing I don’t want any Mexican anywhere else again!", new DateTime(2020, 6, 23, 11, 57, 8, 625, DateTimeKind.Local).AddTicks(7248) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Comment", "ReviewDate" },
                values: new object[] { "We love Agave! Very family friendly, great prices, great food and nice staff! Highly recommend their queso and chips! This is a fast casual type of restaurant.", new DateTime(2020, 6, 23, 11, 57, 8, 625, DateTimeKind.Local).AddTicks(7265) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Comment", "ReviewDate" },
                values: new object[] { "Surprisingly, there are not many Cleveland restaurants with a good lake view, but Pier W has the best. Plus, the selections of meals for lunch are outstanding. The service was excellent and meals reasonable and filling. We enjoyed perch, salmon, scallops, The lobster bisque and manilla clam chowder were equally tasty. Our guests left satisfied and impressed with their visit to Lakewood and Pier W.", new DateTime(2020, 6, 23, 11, 57, 8, 625, DateTimeKind.Local).AddTicks(7282) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Comment", "ReviewDate" },
                values: new object[] { "Ventured to Pier W for dinner on our 22nd wedding anniversary. We were seated quickly with a waterview despite our running late. Our server was polite, knowledgeable & helpful. Our ceviche appetizer was just so-so, but the lobster bisque was delicious. Our dinners consisted of lobster pappardelle & bouillabaisse. The lobster pappardelle was done in a cream sauce that was well- balanced. The bouillabaisse was outstanding; loaded with scallops, muscles, shrimp, scallops & fish. The accompanying broth was fantastic & didn't overpower the seafood. We received a complimentary cheesecake for our anniversary that was very good & the wife took a serving of Buttercake home for good measure... and the next morning's snack.", new DateTime(2020, 6, 23, 11, 57, 8, 625, DateTimeKind.Local).AddTicks(7298) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Comment", "ReviewDate" },
                values: new object[] { "I am one who doesn't complain, but when I went to Pier W I witnessed an injustice that ruined my whole experience there. I witnessed the general manager. Scream at and berate a poor teenage busser for not moving a chair down to a table fast enough for his liking. Then the man noticed us watching him. He approached our table right by the stars. My girlfriend and I felt awkward after seeing this man throw a tempertantrum, come up to us calmly and ask us how our dinner is going. After a awkward conversation that lasted way to long with him, he walked away. 20 mins after he was screaming at someone in his headset. Nice restaurant, bad manager!!!", new DateTime(2020, 6, 23, 11, 57, 8, 625, DateTimeKind.Local).AddTicks(7314) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1,
                column: "Details",
                value: "Great pizza place");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 2,
                column: "Details",
                value: "Like chipotle but 10x better");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 3,
                column: "Details",
                value: "Really great seafood");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Comment", "ReviewDate" },
                values: new object[] { " Pepporoni Pizza is awesome", new DateTime(2020, 6, 19, 13, 39, 1, 536, DateTimeKind.Local).AddTicks(4933) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Comment", "ReviewDate" },
                values: new object[] { "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed est quam, ornare sit amet pretium non, posuere rhoncus dui. Curabitur gravida risus eget risus scelerisque, eu tristique velit accumsan. Nam ligula purus, sagittis sed dolor vitae, posuere accumsan purus. Donec metus velit, commodo eu viverra in, lobortis ac diam. Suspendisse lacinia mi mauris, at ultrices dolor maximus eget. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos", new DateTime(2020, 6, 19, 13, 39, 1, 541, DateTimeKind.Local).AddTicks(4134) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Comment", "ReviewDate" },
                values: new object[] { "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed est quam, ornare sit amet pretium non, posuere rhoncus dui. Curabitur gravida risus eget risus scelerisque, eu tristique velit accumsan. Nam ligula purus, sagittis sed dolor vitae, posuere accumsan purus. Donec metus velit, commodo eu viverra in, lobortis ac diam. Suspendisse lacinia mi mauris, at ultrices dolor maximus eget. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos", new DateTime(2020, 6, 19, 13, 39, 1, 541, DateTimeKind.Local).AddTicks(4233) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Comment", "ReviewDate" },
                values: new object[] { " Their burritos were great!", new DateTime(2020, 6, 19, 13, 39, 1, 541, DateTimeKind.Local).AddTicks(4244) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Comment", "ReviewDate" },
                values: new object[] { " Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed est quam, ornare sit amet pretium non, posuere rhoncus dui. Curabitur gravida risus eget risus scelerisque, eu tristique velit accumsan. Nam ligula purus, sagittis sed dolor vitae, posuere accumsan purus. Donec metus velit, commodo eu viverra in, lobortis ac diam. Suspendisse lacinia mi mauris, at ultrices dolor maximus eget. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos", new DateTime(2020, 6, 19, 13, 39, 1, 541, DateTimeKind.Local).AddTicks(4249) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Comment", "ReviewDate" },
                values: new object[] { "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed est quam, ornare sit amet pretium non, posuere rhoncus dui. Curabitur gravida risus eget risus scelerisque, eu tristique velit accumsan. Nam ligula purus, sagittis sed dolor vitae, posuere accumsan purus. Donec metus velit, commodo eu viverra in, lobortis ac diam. Suspendisse lacinia mi mauris, at ultrices dolor maximus eget. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos", new DateTime(2020, 6, 19, 13, 39, 1, 541, DateTimeKind.Local).AddTicks(4255) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Comment", "ReviewDate" },
                values: new object[] { "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed est quam, ornare sit amet pretium non, posuere rhoncus dui. Curabitur gravida risus eget risus scelerisque, eu tristique velit accumsan. Nam ligula purus, sagittis sed dolor vitae, posuere accumsan purus. Donec metus velit, commodo eu viverra in, lobortis ac diam. Suspendisse lacinia mi mauris, at ultrices dolor maximus eget. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos", new DateTime(2020, 6, 19, 13, 39, 1, 541, DateTimeKind.Local).AddTicks(4260) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Comment", "ReviewDate" },
                values: new object[] { "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed est quam, ornare sit amet pretium non, posuere rhoncus dui. Curabitur gravida risus eget risus scelerisque, eu tristique velit accumsan. Nam ligula purus, sagittis sed dolor vitae, posuere accumsan purus. Donec metus velit, commodo eu viverra in, lobortis ac diam. Suspendisse lacinia mi mauris, at ultrices dolor maximus eget. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos", new DateTime(2020, 6, 19, 13, 39, 1, 541, DateTimeKind.Local).AddTicks(4265) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Comment", "ReviewDate" },
                values: new object[] { "The seafood here is pretty ok for Lake Erie", new DateTime(2020, 6, 19, 13, 39, 1, 541, DateTimeKind.Local).AddTicks(4269) });
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Art.Migrations
{
    public partial class settingSomeData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Country", "Email", "FirstName", "ImageArtist", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "Netherlands", "Sonja@gmail.com", "Sonja", "https://dutch-accent.nl/wp-content/uploads/sonjabrussen.jpg", "Brussen", "0739888159" },
                    { 2, "Italy", "Marco@gmail.com", "Marco", "https://cdn.singulart.com/artists/pictures/cropped/artwork/base/artist_artwork_6167_67251a429f48bec92ea62a94abc63de9.jpeg", "Barberio", "0739888159" },
                    { 3, "Russian", "Tatiana@gmail.com", "Tatiana", "https://d3rf6j5nx5r04a.cloudfront.net/nTSKy_xfl-jCkClViyQ6eWWGzMI=/240x240/artists/e/0/9a4985a64d294797bc1af8f94ef6407e.jpg", "Golovko", "0739888159" }
                });

            migrationBuilder.InsertData(
                table: "Paintings",
                columns: new[] { "PainingId", "ArtistId", "DrawingYear", "Image", "Length", "PaintingName", "PaintingType", "Price", "Width" },
                values: new object[,]
                {
                    { 1, null, "2020", "https://d3rf6j5nx5r04a.cloudfront.net/ygDxGa-_V-LBxFPO1SkGf0BS4zc=/1120x0/product/5/0/75fffbcf840b4b0ca7844ce74a92d220_opt.jpg", 140, "Silence of nature", "Oil Painting", 280m, 100 },
                    { 2, null, "2021", "https://d3rf6j5nx5r04a.cloudfront.net/C775hrN-B1Rl1djwrujZr7N2ESs=/1120x0/product/9/8/324997ae1ef14461ba1ee7ba552b6938_opt.jpg", 52, "Lucky", "Oil Painting", 93m, 42 },
                    { 3, null, "2021", "https://d3rf6j5nx5r04a.cloudfront.net/XilzqOuifRkv1zKLP09iWR0eCO4=/1120x0/product/9/8/bfd0972cc5c74aab8b09a4087cdb944b_opt.jpg", 52, "Behind the scene", "Oil painting", 180m, 42 },
                    { 4, null, "2021", "https://d3rf6j5nx5r04a.cloudfront.net/oOKee0RsyKA2gneb7h_Yh7HW6Pg=/1120x0/product/9/7/1f60fe1fd06a44d3a64b256e4378f06e_opt.jpg", 92, "All Stars and Stripes", "Acrylic painting", 160m, 92 },
                    { 5, null, "2021", "https://d3rf6j5nx5r04a.cloudfront.net/38c6ejyvy2XwIYneBvMWtPj3QOc=/1120x0/product/6/d/f26a45c5bacc417aa22cdac707e85f2e_opt.jpg", 49, "Marco Barberio", "Acrylic painting", 120m, 49 },
                    { 6, null, "2020", "https://d3rf6j5nx5r04a.cloudfront.net/lhtIroduPQs7rw2o2xHzq4lQo24=/1120x0/product/5/1/a61eee843cfa4808a1871b0d828e4ba0_opt.jpg", 56, "A Moment", "Watercolour", 102m, 76 },
                    { 7, null, "2020", "https://d3rf6j5nx5r04a.cloudfront.net/jOpVoXqc7I9FaAiSoCWOpf2erp0=/1120x0/product/5/4/4aef2de04b964796b07576750c42ce5e_opt.jpeg", 56, "Birds-of-Paradise", "Watercolour", 180m, 76 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Paintings",
                keyColumn: "PainingId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Paintings",
                keyColumn: "PainingId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Paintings",
                keyColumn: "PainingId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Paintings",
                keyColumn: "PainingId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Paintings",
                keyColumn: "PainingId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Paintings",
                keyColumn: "PainingId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Paintings",
                keyColumn: "PainingId",
                keyValue: 7);
        }
    }
}

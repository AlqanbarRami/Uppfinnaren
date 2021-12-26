using Microsoft.EntityFrameworkCore;

namespace Art.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            this.Database.EnsureCreated();  
        }

        public DbSet<Painting> Paintings { get; set; }
        public DbSet<Artist> Artists { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Artist>().HasData(new Artist { ArtistId = 1, FirstName = "Sonja", LastName = "Brussen", Country = "Netherlands", Email = "Sonja@gmail.com", PhoneNumber = "0739888159", ImageArtist = "https://d3rf6j5nx5r04a.cloudfront.net/pmkj-Wcw7TQNWHYgMoGrxdTWISk=/240x240/artists/d/1/de0f1701ce934f5dbc51910ad633d135.jpg" });
            modelBuilder.Entity<Artist>().HasData(new Artist { ArtistId = 2, FirstName = "Marco", LastName = "Barberio", Country = "Italy", Email = "Marco@gmail.com", PhoneNumber = "0739888159", ImageArtist = "https://d3rf6j5nx5r04a.cloudfront.net/-NYbmsCIL0sS4pxfw5dfdfwFio4=/240x240/artists/b/0/2e5e853d21f849d3abced84fa9c5b2aa.jpg" });
            modelBuilder.Entity<Artist>().HasData(new Artist { ArtistId = 3, FirstName = "Tatiana", LastName = "Golovko", Country = "Russian", Email = "Tatiana@gmail.com", PhoneNumber = "0739888159", ImageArtist = "https://d3rf6j5nx5r04a.cloudfront.net/nTSKy_xfl-jCkClViyQ6eWWGzMI=/240x240/artists/e/0/9a4985a64d294797bc1af8f94ef6407e.jpg" });
            modelBuilder.Entity<Artist>().HasData(new Artist { ArtistId = 4, FirstName = "SANJAY", LastName = "PUNEKAR", Country = "India", Email = "SANJAY@gmail.com", PhoneNumber = "0739888159", ImageArtist = "https://d3rf6j5nx5r04a.cloudfront.net/3bZAdWBzDeNTJYBohjbYw-NmBIU=/240x240/artists/9/b/75085a01f4da48c3926e613563a396ae.jpg" });
            modelBuilder.Entity<Artist>().HasData(new Artist { ArtistId = 5, FirstName = "Ole", LastName = "Karako", Country = "Ukraine", Email = "Ole@gmail.com", PhoneNumber = "0739888159", ImageArtist = "https://d3rf6j5nx5r04a.cloudfront.net/kEDFPaHyIbfWOUkuxDJ5fs8Pre0=/240x240/artists/5/0/d0f1db55078b42959cf67c575a3e38b6.jpg" });






            modelBuilder.Entity<Painting>().HasData(new Painting
            {
                PainingId = 1,
                PaintingName = "Silence of nature",
                PaintingType = "Oil Painting",
                Length = 140,
                Width = 100,
                DrawingYear = "2020",
                Image = "https://d3rf6j5nx5r04a.cloudfront.net/ygDxGa-_V-LBxFPO1SkGf0BS4zc=/1120x0/product/5/0/75fffbcf840b4b0ca7844ce74a92d220_opt.jpg",
                Price = 280,
                ArtistId = 1
            }) ; 
            modelBuilder.Entity<Painting>().HasData(new Painting
            {
                PainingId = 2,
                PaintingName = "Lucky",
                PaintingType = "Oil Painting",
                Length = 52,
                Width = 42,
                DrawingYear = "2021",
                Image = "https://d3rf6j5nx5r04a.cloudfront.net/C775hrN-B1Rl1djwrujZr7N2ESs=/1120x0/product/9/8/324997ae1ef14461ba1ee7ba552b6938_opt.jpg",
                Price = 93,
                ArtistId = 1

            });
            modelBuilder.Entity<Painting>().HasData(new Painting
            {
                PainingId = 3,
                PaintingName = "Behind the scene",
                PaintingType = "Oil Painting",
                Length = 52,
                Width = 42,
                DrawingYear = "2021",
                Image = "https://d3rf6j5nx5r04a.cloudfront.net/XilzqOuifRkv1zKLP09iWR0eCO4=/1120x0/product/9/8/bfd0972cc5c74aab8b09a4087cdb944b_opt.jpg",
                Price = 180,
                ArtistId = 1

            });

            modelBuilder.Entity<Painting>().HasData(new Painting
            {
                PainingId = 4,
                PaintingName = "All Stars and Stripes",
                PaintingType = "Acrylic Painting",
                Length = 92,
                Width = 92,
                DrawingYear = "2021",
                Image = "https://d3rf6j5nx5r04a.cloudfront.net/oOKee0RsyKA2gneb7h_Yh7HW6Pg=/1120x0/product/9/7/1f60fe1fd06a44d3a64b256e4378f06e_opt.jpg",
                Price = 160,
                ArtistId = 2
            });
            modelBuilder.Entity<Painting>().HasData(new Painting
            {
                PainingId = 5,
                PaintingName = "Marco Barberio",
                PaintingType = "Acrylic Painting",
                Length = 49,
                Width = 49,
                DrawingYear = "2021",
                Image = "https://d3rf6j5nx5r04a.cloudfront.net/38c6ejyvy2XwIYneBvMWtPj3QOc=/1120x0/product/6/d/f26a45c5bacc417aa22cdac707e85f2e_opt.jpg",
                Price = 120,
                ArtistId=2
            });
            modelBuilder.Entity<Painting>().HasData(new Painting
            {
                PainingId = 6,
                PaintingName = "A Moment",
                PaintingType = "Watercolour",
                Length = 56,
                Width = 76,
                DrawingYear = "2020",
                Image = "https://d3rf6j5nx5r04a.cloudfront.net/lhtIroduPQs7rw2o2xHzq4lQo24=/1120x0/product/5/1/a61eee843cfa4808a1871b0d828e4ba0_opt.jpg",
                Price = 102,
                ArtistId = 3
            });
            modelBuilder.Entity<Painting>().HasData(new Painting
            {
                PainingId = 7,
                PaintingName = "Birds-of-Paradise",
                PaintingType = "Watercolour",
                Length = 56,
                Width = 76  ,
                DrawingYear = "2020",
                Image = "https://d3rf6j5nx5r04a.cloudfront.net/jOpVoXqc7I9FaAiSoCWOpf2erp0=/1120x0/product/5/4/4aef2de04b964796b07576750c42ce5e_opt.jpeg",
                Price = 180,
                ArtistId = 3
                
            });

            modelBuilder.Entity<Painting>().HasData(new Painting
            {
                PainingId = 8,
                PaintingName = "Glory of nature",
                PaintingType = "Acrylic Painting",
                Length = 86,
                Width = 76  ,
                DrawingYear = "2021",
                Image = "https://d3rf6j5nx5r04a.cloudfront.net/mmqOLvdz9RDB_tJnnt_w2vLyriQ=/1120x0/product/e/7/31ee14f20f794fb7865e674f54606386_opt.jpg",
                Price = 130,
                ArtistId = 4
                
            });

            modelBuilder.Entity<Painting>().HasData(new Painting
            {
                PainingId = 9,
                PaintingName = "Morning glory 15",
                PaintingType = "Acrylic Painting",
                Length = 86,
                Width = 76  ,
                DrawingYear = "2021",
                Image = "https://d3rf6j5nx5r04a.cloudfront.net/m2_BRm9utCJbngiWwvUf1VJp1Qc=/1120x0/product/0/1/0cc9cdd4739a4c25996161c1e64090f3_opt.jpg",
                Price = 100,
                ArtistId = 4
                
            });


            modelBuilder.Entity<Painting>().HasData(new Painting
            {
                PainingId = 10,
                PaintingName = "Ukrainian Winter",
                PaintingType = "Oil Painting",
                Length = 96,
                Width = 76  ,
                DrawingYear = "2020",
                Image = "https://d3rf6j5nx5r04a.cloudfront.net/BvxWnOn5yeaGEMUtzOsuSOpoIu0=/1120x0/product/4/e/014d786881474cc8bb8b7e3b16a1f983_opt.jpg",
                Price = 90,
                ArtistId = 5
                
            });

        }


    }
}

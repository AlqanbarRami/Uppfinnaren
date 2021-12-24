using System;
using System.Collections.Generic;
using System.Linq;
using Art.Models;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace test
{
    public class ArtTest
    {
        [Fact]
        public void TestingNumberOfAristsAndPaintings()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase("Painings").Options;
            using (var appDbContext = new AppDbContext(options))
            {
                ArtistRepository artist = new ArtistRepository(appDbContext);
                PaintingRepository paintings = new PaintingRepository(appDbContext);
                var myArtist = artist.AllArtist;
                var myPaintings = paintings.AllPainting;
                List<Artist> allArtist = new List<Artist>();
                List<Painting> allParintings = new List<Painting>();
                foreach (var art in myArtist)
                {
                    allArtist.Add(art);
                }
                foreach (var paint in myPaintings)
                {
                    allParintings.Add(paint);
                }
                var expectedNumberOfArtists = allArtist.Count;
                var expectedNumberOfPaintings = allParintings.Count;
                var actualNumberOfArtists = myArtist.Count();
                var actualNumberOfPaintings = myPaintings.Count();

                Assert.Equal(expectedNumberOfArtists, actualNumberOfArtists);
                Assert.Equal(expectedNumberOfPaintings, actualNumberOfPaintings);

            }
        }

        [Fact]
        public void TestGetArtistDetailsById()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase("Painings").Options;
            using (var appDbContext = new AppDbContext(options))
            {
                ArtistRepository artist = new ArtistRepository(appDbContext);
                var myArtist = artist.AllArtist;
                List<Artist> allArtistInfo  = new List<Artist>();
                string artistName = "";
                foreach (var art in myArtist)
                {
                    if(art.ArtistId == 1){
                        artistName = art.FirstName;
                        allArtistInfo.Add(art);
                    }
                    
                }
                //For just the name;
                var expectedName = artistName;
                var actualName = artist.AllArtist.Where(a=>a.FirstName == "Sonja").Select(n=>n.FirstName).Single(); 
                // did I get all info For Sonja? 
                var expectedNumberOfItmes = allArtistInfo.Count;
                var actualNumberOfItems = artist.AllArtist.Where(a=> a.ArtistId == 1 ).Count();
                // I don't want another Artist just Sonja
                int NotExpectedId = 3;
                int actualId = allArtistInfo.Select(a=>a.ArtistId).FirstOrDefault();


                Assert.Same(expectedName, actualName);
                Assert.Equal(expectedNumberOfItmes,actualNumberOfItems);
                Assert.NotSame(NotExpectedId,actualId);
            }
        }



        [Fact]
        public void TestPaintingsFilter()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase("Painings").Options;
            using (var appDbContext = new AppDbContext(options))
            {
             
                PaintingRepository paintings = new PaintingRepository(appDbContext);

                var myPaintings = paintings.AllPainting;
                
                List<Painting> PaintingsForSonja = new List<Painting>();
                List<Painting> PaintingsForMarco = new List<Painting>();
                foreach (var art in myPaintings)
                {
                    if(art.ArtistId == 1 && art.Artist.FirstName == "Sonja")
                    {
                        PaintingsForSonja.Add(art);
                    }
                    if (art.ArtistId == 2 && art.Artist.FirstName == "Marco")
                    {
                        PaintingsForMarco.Add(art);
                    }
                }

                var getTotlaPaintingsForSonja = paintings.AllPainting.Where(p => p.ArtistId == 1).Count();
                var getFoundingPaintingsSonja = PaintingsForSonja.Count;
                var getTotalPaintingsForMarco = paintings.AllPainting.Where(p => p.ArtistId == 2).Count();
                var getFoundingPaintingsMarco = PaintingsForMarco.Count;

                Assert.Equal(getFoundingPaintingsSonja,getTotlaPaintingsForSonja);
                Assert.Equal(getFoundingPaintingsMarco, getTotalPaintingsForMarco);

            }
        }
            
    }
}

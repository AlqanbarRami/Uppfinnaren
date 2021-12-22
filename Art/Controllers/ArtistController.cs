using Art.Models;
using Art.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Art.Controllers
{
    public class ArtistController : Controller
    {
        private readonly IArtistRepository artistRepository;
        private readonly IPaintingRepository paintingRepository;    


        public ArtistController( IArtistRepository artistRepository)
        {
            this.artistRepository = artistRepository;
        }

        public IActionResult Artists()
        {
            return View(artistRepository.AllArtist);
        }

        public ViewResult Details(int id)
        {
            IEnumerable<Artist> getArtist;
            
            getArtist = artistRepository.AllArtist.Where(a =>a.ArtistId == id).OrderBy(a=>a.ArtistId);
            return View(new ArtistsViewModel { Artists = getArtist});  
        }

        public ViewResult getAllArtist()
        {
            IEnumerable<Artist> getArtist;

            getArtist = artistRepository.AllArtist.OrderBy(a => a.ArtistId);
            return View(new ArtistsViewModel { Artists = getArtist });
        }








    }
}

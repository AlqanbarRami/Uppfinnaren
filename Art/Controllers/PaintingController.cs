using Microsoft.AspNetCore.Mvc;
using Art.Models;
using Art.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace Paintings.Controllers
{
    public class PaintingController : Controller
    {
        private readonly IPaintingRepository paintingRepository;
        private readonly IArtistRepository artistRepository;


        public PaintingController(IPaintingRepository paintingRepository, IArtistRepository artistRepository)
        {
            this.paintingRepository = paintingRepository;
            this.artistRepository = artistRepository;
        }

        public IActionResult AllPainting()
        {
            PaintingViewModel paintingViewModel = new PaintingViewModel();
            paintingViewModel.Paintings = paintingRepository.AllPainting;
            return View(paintingViewModel);
        }

        public IActionResult getPainting(int id)
        {
            IEnumerable<Painting> getPainting;
            getPainting = paintingRepository.AllPainting.Where(p => p.PainingId == id); 


            return View(new PaintingViewModel { Paintings = getPainting});
        }




        public ViewResult List(int id)
        {
            IEnumerable<Painting> paint;

            paint = paintingRepository.AllPainting.Where(p => p.Artist.ArtistId == id).OrderBy(p => p.PainingId);
            
            return View(new PaintingViewModel
            {
                Paintings = paint,

            });
        }

    







    }
}

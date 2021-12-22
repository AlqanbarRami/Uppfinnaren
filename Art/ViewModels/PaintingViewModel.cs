using System.Collections.Generic;
using Art.Models;

namespace Art.ViewModels
{
    public class PaintingViewModel
    {
        public IEnumerable<Painting> Paintings { get; set; }
    }
}

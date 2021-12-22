using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Art.Models
{
    public class PaintingRepository : IPaintingRepository
    {
        private readonly AppDbContext appDbContext;

        public PaintingRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public IEnumerable<Painting> AllPainting
        {
            get
            {
                return appDbContext.Paintings.Include(a => a.Artist);
            }
        }
            /*
        public Painting GetPainting(int PaintId)
        {
            return appDbContext.Paintings.FirstOrDefault(p => p.PainingId == PaintId);
        }
        */
    }
}

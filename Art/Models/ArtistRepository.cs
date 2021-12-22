using System.Collections.Generic;

namespace Art.Models
{
    public class ArtistRepository : IArtistRepository
    {
        private readonly AppDbContext appDbContext;

        public ArtistRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public IEnumerable<Artist> AllArtist =>  appDbContext.Artists;
    }
}

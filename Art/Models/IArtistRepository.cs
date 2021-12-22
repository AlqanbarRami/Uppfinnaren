using System.Collections.Generic;

namespace Art.Models
{
    public interface IArtistRepository
    {
        IEnumerable<Artist> AllArtist { get; }
       
    }
}

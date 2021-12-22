using System.Collections.Generic;

namespace Art.Models
{
    public interface IPaintingRepository
    {
        IEnumerable<Painting> AllPainting { get; }
        
    }
}

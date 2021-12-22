using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Art.Models
{
    public class Artist
    {
        public int ArtistId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Country { get; set; }
        public string ImageArtist { get; set; }
        public List<Painting> Paintings { get; set; }

    }
}

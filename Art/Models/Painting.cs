using System.ComponentModel.DataAnnotations;

namespace Art.Models
{
    public class Painting
    {   [Key]
        public int PainingId { get; set; }
        public string PaintingName { get; set; }
        public string PaintingType { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public string DrawingYear { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public int ArtistId { get; set; }   
        public Artist Artist { get; set; }  


    }
}

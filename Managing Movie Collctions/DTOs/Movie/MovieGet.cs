using Managing_Movie_Collctions.DTOs.Categories;
using Managing_Movie_Collctions.DTOs.Director;
using System.ComponentModel.DataAnnotations;

namespace Managing_Movie_Collctions.DTOs.Movie
{
    public class MovieGet
    {
        [Required]
        [StringLength(200)]
        public string Title { get; set; }
        public DateTime ReleaseYear { get; set; }
        public ICollection<DirectorsDTO> Directors { get; set; }
        public CategoriesDTO Category { get; set; }
    }
}

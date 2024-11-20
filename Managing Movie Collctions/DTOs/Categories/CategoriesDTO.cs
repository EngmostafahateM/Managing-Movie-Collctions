using Managing_Movie_Collctions.DTOs.Movie;
using System.ComponentModel.DataAnnotations;

namespace Managing_Movie_Collctions.DTOs.Categories
{
    public class CategoriesDTO
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public ICollection<MovieGet> Movies { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace Managing_Movie_Collctions.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public ICollection<Movie> Movies { get; set;}
    }
}

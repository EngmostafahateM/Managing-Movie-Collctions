using System.ComponentModel.DataAnnotations;

namespace Managing_Movie_Collctions.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }
        public DateTime ReleaseYear { get; set; }

        public ICollection<Director> Directors { get; set; }
        public Category Category { get; set; }
    }
}

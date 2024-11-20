using System.ComponentModel.DataAnnotations;

namespace Managing_Movie_Collctions.Models
{
    public class Nationality
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public Director Director { get; set; }
    }
}

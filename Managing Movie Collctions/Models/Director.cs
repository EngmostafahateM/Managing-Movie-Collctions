using System.ComponentModel.DataAnnotations;

namespace Managing_Movie_Collctions.Models
{
    public class Director
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Phone(ErrorMessage =("Please enter Your Phone Number"))]
        public string Contact { get; set; }

        [EmailAddress(ErrorMessage ="Please enter your Email")]
        public string Email { get; set; }
        public ICollection<Movie> Movies { get; set; }
        public int NationalityID { get; set; }
        public Nationality Nationality { get; set; }
    }
}

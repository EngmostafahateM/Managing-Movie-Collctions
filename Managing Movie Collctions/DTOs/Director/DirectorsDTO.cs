using Managing_Movie_Collctions.DTOs.Movie;
using Managing_Movie_Collctions.DTOs.Nationality;
using Managing_Movie_Collctions.Models;
using System.ComponentModel.DataAnnotations;

namespace Managing_Movie_Collctions.DTOs.Director
{
    public class DirectorsDTO
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Phone(ErrorMessage = ("Please enter Your Phone Number"))]
        public string Contact { get; set; }

        [EmailAddress(ErrorMessage = "Please enter your Email")]
        public string Email { get; set; }
        public ICollection<MovieGet> Movies { get; set; }
        public int NationalityID { get; set; }
        public NationalityDTO Nationality { get; set; }
    }
}

using Managing_Movie_Collctions.DTOs.Director;
using System.ComponentModel.DataAnnotations;

namespace Managing_Movie_Collctions.DTOs.Nationality
{
    public class NationalityDTO
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public DirectorsDTO Director { get; set; }
    }
}

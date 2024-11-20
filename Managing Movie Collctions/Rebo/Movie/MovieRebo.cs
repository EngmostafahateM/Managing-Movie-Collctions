using Managing_Movie_Collctions.Data;
using Managing_Movie_Collctions.DTOs.Categories;
using Managing_Movie_Collctions.DTOs.Director;
using Managing_Movie_Collctions.DTOs.Movie;
using Managing_Movie_Collctions.DTOs.Nationality;
using Microsoft.EntityFrameworkCore;

namespace Managing_Movie_Collctions.Rebo.Movie
{
    public class _MovieRebo : IMoveRebo
    {
        private readonly ApplicationDbContext _context;
        public _MovieRebo(ApplicationDbContext context)
        {
            _context = context;
        }

        public MovieGet Add(MovieGet movie)
        {
            var movies = new MovieGet
            {
                Title = movie.Title,
                ReleaseYear = movie.ReleaseYear,
                Directors = movie.Directors,
                Category = movie.Category,

            };

            _context.Add( movies );
            _context.SaveChanges();
            return movie;
            
        }

        public List<MovieGet> movieGetallDTOs()
        {
            var Movise = _context.Movies.Include(x => x.Category)
                .Include(x => x.Directors)
                .ThenInclude(x => x.Nationality)
                .Select(x => new MovieGet
                {
                    Title = x.Title,
                    ReleaseYear = x.ReleaseYear,
                    Category =new CategoriesDTO
                    {
                        Name = x.Category.Name,
                    },
                    Directors = x.Directors.Select(d => new DirectorsDTO
                    {
                        Nationality = new NationalityDTO
                        {
                            Name = d.Name,
                        },
                    }).ToList(),
                }).ToList();

            return Movise;
        }

        public MovieGet movieGetbyid(int id)
        {
            var movise = _context.Movies
                .Where(a => a.Id == id)
                .Include(i => i.Category)
                .Include(i => i.Directors)
                .ThenInclude(c => c.Nationality.Name)
                .Select(a => new MovieGet
                {
                    Title = a.Title,
                    ReleaseYear = a.ReleaseYear,
                    Category = new CategoriesDTO
                    {
                        Name = a.Category.Name,
                    },
                    Directors = a.Directors.Select(d => new DirectorsDTO
                    {
                        Nationality = new NationalityDTO
                        {
                            Name = d.Name,
                        },
                    }).ToList(),
                }).FirstOrDefault();

            return movise;
        }
    }
}









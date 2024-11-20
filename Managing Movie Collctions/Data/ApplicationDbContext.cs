using Managing_Movie_Collctions.Models;
using Microsoft.EntityFrameworkCore;

namespace Managing_Movie_Collctions.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Nationality> Nationalities { get; set; }

    }
}

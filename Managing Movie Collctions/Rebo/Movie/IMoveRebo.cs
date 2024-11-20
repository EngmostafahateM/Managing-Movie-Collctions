using Managing_Movie_Collctions.DTOs.Movie;

namespace Managing_Movie_Collctions.Rebo.Movie
{
    public interface IMoveRebo
    {
        public List<MovieGet> movieGetallDTOs();
        public MovieGet movieGetbyid(int id);
        public MovieGet Add(MovieGet movie);
    }
}

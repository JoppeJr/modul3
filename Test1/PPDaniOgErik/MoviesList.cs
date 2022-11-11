using System.ComponentModel;

namespace PPDaniOgErik;

public class MoviesList
{
    public List<Movie> Movies { get; set; }

    public MoviesList()
    {
        Movies = new List<Movie>();
        Movies.Add(new Movie(1, "Lord Of The Rings: Fellowship", "Fantasy", 300));
        Movies.Add(new Movie(2, "Lord Of The Rings: Two Towers", "Fantasy", 290));
        Movies.Add(new Movie(4, "Lord Of The Rings: Return of the King", "Fantasy", 280));
        Movies.Add(new Movie(5, "Hobbit: unexpected journey ", "Fantasy", 220));
        Movies.Add(new Movie(6, "Hobbit: The desilation of Smaug", "Fantasy", 230));
        Movies.Add(new Movie(7, "Hobbit: the Five armys", "Fantasy", 250));
        Movies.Add(new Movie(8, "GrownUps", "Comedy", 112));
        Movies.Add(new Movie(9, "Call Jane", "Drama", 121));
        Movies.Add(new Movie(10, "Black Adam", "Action", 126));
        Movies.Add(new Movie(11, "Jentetur", "Comedy", 95));
        Movies.Add(new Movie(12, "Black Panther", "Action", 162));
    }

    public void PrintAllMovies()
    {
        foreach (var movie in Movies)
        {
            Console.WriteLine(movie.ToString());
        }
    }
}
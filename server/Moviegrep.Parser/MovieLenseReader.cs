using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moviegrep.Parser
{
    internal static class MovieLenseReader
    {

        internal static IEnumerable<MovieLenseRating> GetMovieLenseRating(string path)
        {
            var result = new List<MovieLenseRating>();

            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(path);
            while ((line = file.ReadLine()) != null)
            {
                var parts = line.Split(new string[] { ",", "\t" }, StringSplitOptions.RemoveEmptyEntries);
                var rating = new MovieLenseRating();
                rating.UserId = Convert.ToInt32(parts[0]);
                rating.MovieId = Convert.ToInt32(parts[1]);
                rating.Rating = Convert.ToDecimal(parts[2]);
                result.Add(rating);
            }

            file.Close();

            return result;
        }

        internal static IEnumerable<MovieLenseMovie> GetMovieLenseMovie(string path)
        {
            var result = new List<MovieLenseMovie>();

            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(path);
            while ((line = file.ReadLine()) != null)
            {
                var parts = line.Split(new string[] { ",", "\t" }, StringSplitOptions.RemoveEmptyEntries);
                var movie = new MovieLenseMovie();
                movie.MovieId = Convert.ToInt32(parts[0]);
                movie.Title = parts[1];
                movie.Genre = parts[2];

                result.Add(movie);
            }

            file.Close();

            return result;
        }

    }
}

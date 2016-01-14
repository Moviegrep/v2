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
            int movieId;
            while ((line = file.ReadLine()) != null)
            {
                var parts = line.Split(new string[] { ",", "\t" }, StringSplitOptions.RemoveEmptyEntries);
                var movie = new MovieLenseMovie();
                if (int.TryParse(parts[0], out movieId))
                {
                    movie.MovieId = movieId;
                    movie.Title = parts[1];
                    movie.Genre = parts[2];
                }
                result.Add(movie);
            }

            file.Close();

            return result;
        }

        internal static IEnumerable<dynamic> GetMovieLenseMovieDynamic(string path)
        {
            var result = new List<dynamic>();

            string line;
            using (System.IO.StreamReader file = new System.IO.StreamReader(path))
            {
                while ((line = file.ReadLine()) != null)
                {
                    var parts = line.Split(new string[] { ",", "\t" }, StringSplitOptions.RemoveEmptyEntries);

                    // NOTE: Ideally we can parse the CSV into JSON directly, since we have a documentdb 
                    // all we need is a JSON anyways. So, to make it easier we won't need any strong type actually,
                    // let "dynamic" figure out the types at runtime we can parse this list of dynamic to JSON in db layer

                    var movie = new
                    {
                        MovieId = Convert.ToInt32(parts[0]),
                        Title = parts[1],
                        Genre = parts[2],
                    };
                    result.Add(movie);
                }
            }

            return result;
        }

    }
}

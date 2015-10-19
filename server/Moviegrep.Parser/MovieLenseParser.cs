using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moviegrep.Parser
{
    public class MovieLenseParser<T> : IDatasetParser<T>
    {
        public string Path { get; set; }

        public MovieLenseParser(string path)
        {
            Path = path;
        }

        public IEnumerable<T> Execute()
        {
            var result = new List<MovieLenseRating>();

            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(Path);
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

            return (IEnumerable<T>)result;
            

        }
    }
}

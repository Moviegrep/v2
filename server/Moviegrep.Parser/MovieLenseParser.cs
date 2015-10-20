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
            if (typeof(T).Name.Equals("MovieLenseRating"))
                return (IEnumerable<T>)MovieLenseReader.GetMovieLenseRating(Path);

            if (typeof(T).Name.Equals("MovieLenseMovie"))
                return (IEnumerable<T>)MovieLenseReader.GetMovieLenseMovie(Path);


            return (IEnumerable<T>)null;
        }

    }
}

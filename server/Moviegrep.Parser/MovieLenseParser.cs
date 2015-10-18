using System;
using System.Collections.Generic;
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

        public T Execute()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moviegrep.Parser
{

    public class Parser<T> : IParser<T>
    {
        private IDictionary<String, IDatasetParser<T>> ParserCollection { get; set; }

        public Parser(string path)
        {
            ParserCollection = new Dictionary<String, IDatasetParser<T>>
          {
              { "MovieLense", new MovieLenseParser<T>(path) }
          };
        }

        public T Execute()
        {
            return ParserCollection[typeof(T).ToString()].Execute();
        }
    }
}

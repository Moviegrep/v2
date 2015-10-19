using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moviegrep.Parser
{
    public interface IDatasetParser<out T>
    {
        IEnumerable<T> Execute();           
       
    }
}

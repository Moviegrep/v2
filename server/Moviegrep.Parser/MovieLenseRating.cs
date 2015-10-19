using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moviegrep.Parser
{
    public class MovieLenseRating
    {
        public Int32 UserId { get; set; }
        public Int32 MovieId { get; set; }
        public decimal Rating { get; set; }

        //private MovieLenseRating ParseItemRating(string line)
        //{
        //    var parts = line.Split(new string[] { "::", " ", "\t" }, StringSplitOptions.RemoveEmptyEntries);

        //    var ir = new MovieLenseRating();
        //    //ir.UserId = new MovieLensUser(parts[0]);
        //    //ir.MovieId = new MovieLensItem(parts[1]);
        //    //ir.Rating = Convert.ToInt32(parts[2]);


        //    return ir;
        //}

    }
}

﻿using System;
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

    }
}

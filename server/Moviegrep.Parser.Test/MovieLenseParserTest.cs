using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Moviegrep.Parser.Test
{
    [TestClass]
    public class MovieLenseParserTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var t = new Parser<Moviegrep.Parser.MovieLenseRating>(@"C:\Code\Moviegrep\v2\server\Moviegrep.Parser.Test\TestData\ratings.csv");
            var result = t.Execute();
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Moviegrep.Parser.Test
{
    [TestClass]
    public class MovieLenseParserTest
    {
        [TestMethod]
        public void Should_Return_Ratings()
        {
            //ToDO write some actual test cases these are place holders
            var t = new Parser<Moviegrep.Parser.MovieLenseRating>(@"C:\Code\Moviegrep\v2\server\Moviegrep.Parser.Test\TestData\ratings.csv");
            var result = t.Execute();
        }


        [TestMethod]
        public void Should_Return_Movies()
        {
            //TODO write some actual test cases these are place holders
            var m = new Parser<Moviegrep.Parser.MovieLenseMovie>(@"C:\Code\Moviegrep\v2\server\Moviegrep.Parser.Test\TestData\movies.csv");
            var result = m.Execute();
    }
    }
}

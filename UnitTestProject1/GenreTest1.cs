using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FilmCatalogue;

namespace UnitTestProject1
{
    [TestClass]
    public class GenreTest1
    {
        Catalog catalog = new Catalog();
        [TestMethod]
        public void TestGenreOverload()
        {
            Genre genre1 = new Genre("Test", catalog.ComedyTitles);
            Genre genre2 = new Genre("Example", catalog.ActionTitles);

            var newGenre = genre1 + genre2;

            Assert.AreNotEqual(genre1, newGenre.GetType());
            ReferenceEquals(newGenre, genre1);
        }
        //[TestMethod]
        //public void Test
    }
}

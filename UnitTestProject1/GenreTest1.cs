using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FilmCatalogue;
using System.Collections.Generic;

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
        [TestMethod]
        public void TestAddTitleToGenre()
        {
            catalog.setGenres();
            Genre one = catalog.genreList[0];
            Title title3 = new Film("Taken", 120, 3.5);
            List<Title> list = one.genreTitles;

            list = one + title3;

            Assert.AreEqual(one.genreTitles, list);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FilmCatalogue;

namespace UnitTestProject1
{
    [TestClass]
    public class CatalogueTest1
    {
        
        [TestMethod]
        public void TestThatSettingGenres_setsGenres()
        {
            //arrange
            Catalog catalog = new Catalog();
            Genre genre = new Genre();
            //act
            catalog.setGenres();
            //assert
            foreach(var g in catalog.genreList)
            {
                Assert.IsInstanceOfType(g, genre.GetType());
            }
        }
        [TestMethod]
        public void TestMakeNewGenre()
        {
            //arrange
            Catalog catalog = new Catalog();
            catalog.setGenres();
            catalog.makeNewGenre("test", 3, 1);
            string genreName = "Rom Com";
            int index1 = 2;
            int index2 = 0;
            int expectedGenreCount = catalog.genreList.Count + 1;
            //act
            catalog.makeNewGenre(genreName, index1, index2);
            int genreCount = catalog.genreList.Count;
            //asert
            Assert.AreEqual(expectedGenreCount, genreCount);
        }
        [TestMethod]
        public void TestSetGenresCount()
        {
            Catalog catalog = new Catalog();
            int expectedGenreCount = 4;

            catalog.setGenres();

            Assert.AreEqual(expectedGenreCount, catalog.genreList.Count);
        }
        [TestMethod]
        public void TestViewGenres()
        {
            Catalog catalog = new Catalog();
            catalog.setGenres();

            catalog.viewGenres(); //How do you assert void and printing functions?
        }
        [TestMethod]
        public void TestViewNewGenre()
        {
            Catalog catalog = new Catalog();
            catalog.setGenres();

            catalog.makeNewGenre("TestGenre", 0, 1);

            catalog.viewNewGenre();
        }
        [TestMethod]
        public void TestAddTitleMethod()
        {
            Catalog catalog = new Catalog();
            catalog.setGenres();
            Genre TestGenre = new Genre("test1", catalog.ComedyTitles);
            Genre Test2Genre = new Genre("test2", catalog.ActionTitles);

            catalog.addTitleToGenre(TestGenre, Test2Genre);
        }
    }
}

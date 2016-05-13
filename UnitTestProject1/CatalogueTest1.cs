using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using FilmCatalogue;

namespace UnitTestProject1
{
    [TestClass]
    public class CatalogueTest1
    {
        Catalog catalog = new Catalog();
        [TestMethod]
        public void TestThatSettingGenres_setsGenres()
        {
            //arrange
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
            catalog.setGenres();
            int index1 = 2;
            int index2 = 0;
            int expectedGenreCount = catalog.genreList.Count + 1;
            //act
            catalog.makeNewGenre(index1, index2);
            int genreCount = catalog.genreList.Count;
            //asert
            Assert.AreEqual(expectedGenreCount, genreCount);
        }
        [TestMethod]
        public void TestMakingGenresFail()
        {
            catalog.setGenres();
            catalog.makeNewGenre(5, 7);
            throw new ArgumentOutOfRangeException();
        }
        [TestMethod]
        public void TestSetGenresCount()
        {
            int expectedGenreCount = 4;

            catalog.setGenres();

            Assert.AreEqual(expectedGenreCount, catalog.genreList.Count);
        }
        [TestMethod]
        public void TestViewGenres()
        {
            catalog.setGenres();

            catalog.viewGenres(); //How do you assert void and printing functions?
        }
        [TestMethod]
        public void TestViewNewGenre()
        {
            catalog.setGenres();

            catalog.makeNewGenre(0, 1);

            catalog.viewNewGenre();
        }
        [TestMethod]
        public void TestAddTitleMethod()
        {
            catalog.setGenres();
            Genre TestGenre = new Genre("test1", catalog.ComedyTitles);
            Genre Test2Genre = new Genre("test2", catalog.ActionTitles);

            catalog.addTitleToGenre(TestGenre, Test2Genre);
        }
        [TestMethod]
        public void TestAggregateTitles()
        {
            catalog.setGenres();

            catalog.aggregateTitles();
        }
        [TestMethod]
        public void TestGetComedyTitlesMethod()
        {
            List<Title> titleList = new List<Title>();
            
            ReferenceEquals(catalog.ComedyTitles, titleList.GetType());          
        }
        [TestMethod]
        public void TestGetActionTitlesMethod()
        {
            List<Title> titleList = new List<Title>();

            ReferenceEquals(catalog.ActionTitles, titleList.GetType());
        }
        [TestMethod]
        public void TestGetRomanceTitlesMethod()
        {
            List<Title> titleList = new List<Title>();

            ReferenceEquals(catalog.RomanceTitles, titleList.GetType());
        }
        [TestMethod]
        public void TestGetAllTitlesMethod()
        {
            List<Title> titleList = new List<Title>();

            ReferenceEquals(catalog.AllTitles, titleList.GetType());
        }
    }
}

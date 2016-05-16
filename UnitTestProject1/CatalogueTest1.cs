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
            Genre g1 = catalog.genreList[0];
            Genre g2 = catalog.genreList[1];
            int expectedGenreCount = catalog.genreList.Count + 1;
            //act
            catalog.makeNewGenre(g1, g2);
            int genreCount = catalog.genreList.Count;
            //asert
            Assert.AreEqual(expectedGenreCount, genreCount);
        }
        [TestMethod]
        public void TestMakingGenresFail()
        {
            catalog.setGenres();
            Genre g1 = catalog.genreList[0];
            Genre g2 = catalog.genreList[1];
            catalog.makeNewGenre(g1, g2);
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
            Genre g1 = catalog.genreList[0];
            Genre g2 = catalog.genreList[1];
            catalog.makeNewGenre(g1, g2);

            catalog.viewNewGenre();
        }
        [TestMethod]
        public void TestAddTitleMethod()
        {
            catalog.setGenres();
            Genre TestGenre = new Genre("test1", catalog.ComedyTitles);
            Title TestTitle = new Film("teststring", 120, 3.6);

            catalog.addTitleToGenre(TestGenre, TestTitle);
            //assert
        }
        [TestMethod]
        public void TestAggregateTitles()
        {
            catalog.setGenres();
            Title title1 = new Film("name", 120, 3.5);
            Title title2 = new Film("name", 125, 4.5);
            catalog.aggregateTitles(title1, title2);
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

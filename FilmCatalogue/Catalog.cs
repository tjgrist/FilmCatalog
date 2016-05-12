using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace FilmCatalogue
{
    public class Catalog : IEnumerable
    {
        public List<Genre> genreList = new List<Genre>();

        public IEnumerator GetEnumerator()
        {
            foreach (var g in genreList)
            {
                yield return g.name;
            }
            Console.WriteLine();
        }
        public void setGenres()
        {
            Genre comedy = new Genre("Comedy", getComedyTitles());
            Genre action = new Genre("Action", getActionTitles());
            Genre romance = new Genre("Romance", getRomanceTitles());
            Genre allGenres = new Genre("All", getAllTitles());
            genreList.Add(comedy);
            genreList.Add(action);
            genreList.Add(romance);
            genreList.Add(allGenres);
            Console.WriteLine("Genres set. All titles count: " + allGenres.genreTitles.Count + "\n");
        }
        public void viewGenreTitles()
        {
            foreach (Genre g in genreList)
            {
                Console.WriteLine("Genre: " + g.name);
                foreach(Title t in g.genreTitles)
                {
                    Console.WriteLine(t.name);
                    Console.WriteLine("Duration: " + t.length);
                    Console.WriteLine("Rating: " + t.rating + "\n");
                }
            }
        }
        public void makeNewGenre(string name, int Index1, int Index2)
        {
            Genre newGenre = genreList[Index1] + genreList[Index2];
            genreList.Add(newGenre);
            viewNewGenre(newGenre);
        }
        public void viewNewGenre(Genre newGenre)
        {
            Console.WriteLine(newGenre.name);
            foreach(var title in newGenre)
            {
                Console.WriteLine(title);
            }
        }
        public void addTitleToGenre(Genre genre1, Genre genre2)
        {
            genre1.genreTitles = genre1 + genre2.genreTitles[4];
        }
        public void aggregateTitles()
        {
            Genre customGenre = genreList[1].genreTitles[0] + genreList[0].genreTitles[3];
            genreList.Add(customGenre);
            viewNewGenre(customGenre);
        }
        public List<Title> getComedyTitles()
        {
            List<Title> comedyTitles = new List<Title>();
            Title comedy1 = new Title("Airplane", 120, 4.5);
            Title comedy2 = new Title("Monty Python", 130, 4.7);
            Title comedy3 = new Title("Anchorman", 150, 4.6);
            Title comedy4 = new Title("Ace Ventura", 110, 4.8);
            Title comedy5 = new Title("Hot Tub Time Machine", 134, 3.5);
            comedyTitles.Add(comedy1);
            comedyTitles.Add(comedy2);
            comedyTitles.Add(comedy3);
            comedyTitles.Add(comedy4);
            comedyTitles.Add(comedy5);
            return comedyTitles;
        }
        private List<Title> getActionTitles()
        {
            List<Title> actionTitles = new List<Title>();
            Title action1 = new Title("Die Hard", 145, 4.6);
            Title action2 = new Title("Rambo", 123, 3.5);
            Title action3 = new Title("Predator", 170, 4.1);
            Title action4 = new Title("Avengers", 126, 3.3);
            Title action5 = new Title("Star Wars", 150, 5.0);
            actionTitles.Add(action1);
            actionTitles.Add(action2);
            actionTitles.Add(action3);
            actionTitles.Add(action4);
            actionTitles.Add(action5);
            return actionTitles;
        }
        private List<Title> getRomanceTitles()
        {
            List<Title> romanceTitles = new List<Title>();
            Title romance1 = new Title("The Notebook", 160, 3.9);
            Title romance2 = new Title("Titanic", 180, 4.5);
            Title romance3 = new Title("Annie Hall", 130, 4.2);
            Title romance4 = new Title("Moonrise Kingdom", 140, 3.3);
            Title romance5 = new Title("Casablanca", 127, 3.6);
            Title romance6 = new Title("Punch Drunk Love", 136, 3.9);
            romanceTitles.Add(romance1);
            romanceTitles.Add(romance2);
            romanceTitles.Add(romance3);
            romanceTitles.Add(romance4);
            romanceTitles.Add(romance5);
            romanceTitles.Add(romance6);
            return romanceTitles;
        }
        public List<Title> getAllTitles()
        {
            List<Title> allTitles = new List<Title>();
            Title romance1 = new Title("The Notebook", 160, 3.9);
            Title romance2 = new Title("Titanic", 180, 4.5);
            Title romance3 = new Title("Annie Hall", 130, 4.2);
            Title romance4 = new Title("Moonrise Kingdom", 140, 3.3);
            Title romance5 = new Title("Casablanca", 127, 3.6);
            Title romance6 = new Title("Punch Drunk Love", 136, 3.9);
            Title action1 = new Title("Die Hard", 145, 4.6);
            Title action2 = new Title("Rambo", 123, 3.5);
            Title action3 = new Title("Predator", 170, 4.1);
            Title action4 = new Title("Avengers", 126, 3.3);
            Title action5 = new Title("Star Wars", 150, 5.0);
            Title comedy1 = new Title("Airplane", 120, 4.5);
            Title comedy2 = new Title("Monty Python", 130, 4.7);
            Title comedy3 = new Title("Anchorman", 150, 4.6);
            Title comedy4 = new Title("Ace Ventura", 110, 4.8);
            Title comedy5 = new Title("Hot Tub Time Machine", 134, 3.5);
            allTitles.Add(romance1);
            allTitles.Add(romance2);
            allTitles.Add(romance3);
            allTitles.Add(romance4);
            allTitles.Add(romance5);
            allTitles.Add(romance5);
            allTitles.Add(action1);
            allTitles.Add(action2);
            allTitles.Add(action3);
            allTitles.Add(action4);
            allTitles.Add(action5);
            allTitles.Add(comedy1);
            allTitles.Add(comedy2);
            allTitles.Add(comedy3);
            allTitles.Add(comedy4);
            allTitles.Add(comedy5);
            return allTitles;
        }
    }
}

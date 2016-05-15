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

        public List<Title> ComedyTitles
        {
            get { return getComedyTitles(); }
        }
        public List<Title> ActionTitles
        {
            get { return getActionTitles(); }
        }
        public List<Title> RomanceTitles
        {
            get { return getRomanceTitles(); }
        }
        public List<Title> AllTitles
        {
            get { return getAllTitles(); }
        }

        public IEnumerator GetEnumerator()
        {
            foreach (Genre g in genreList)
            {
                yield return "___" + g.name + "___";
                foreach(Title t in g.genreTitles)
                {
                    yield return t.ToString();
                    yield return "Rating: " + t.Rating + "\n";
                }
            }
        }
        public void setGenres()
        {
            Genre comedy = new Genre("Comedy", ComedyTitles);
            Genre action = new Genre("Action", getActionTitles());
            Genre romance = new Genre("Romance", getRomanceTitles());
            Genre allGenres = new Genre("All", getAllTitles());
            genreList.Add(comedy);
            genreList.Add(action);
            genreList.Add(romance);
            genreList.Add(allGenres);
        }
        public void viewGenres()
        {
            Console.WriteLine("Genres available:");
            foreach(Genre g in genreList)
            {
                Console.WriteLine(g.name);
            }
            Console.WriteLine("Titles available: " + genreList[3].genreTitles.Count);
        }
        public void makeNewGenre(int index1, int index2)
        {
            Genre newGenre = genreList[index1] + genreList[index2];
            genreList.Add(newGenre);
            Console.WriteLine("\n<<<<<<<<<<<< Created a new genre >>>>>>>>>>>>\n");
        }
        public void viewNewGenre()
        {
            Genre newestGenre = genreList.Last();
            Console.WriteLine("\nMade new Genre: " + newestGenre.name);
            foreach(var title in newestGenre)
            {
                Console.WriteLine(title);
            }
        }
        public void addTitleToGenre(Genre genre1, Title title1)
        {
            genre1.genreTitles = genre1 + title1;
            Console.WriteLine("Added '{0}' to {1}.",title1.name, genre1.name);
        }
        public void aggregateTitles()
        {
            Random r = new Random();
            int indx1 = r.Next(0, genreList.Count);
            int indx2 = r.Next(0, genreList.Count);
            int indxTitle = r.Next(0, 5);
            Title title1 = genreList[indx1].genreTitles[indxTitle];
            Title title2 = genreList[indx2].genreTitles[indxTitle];
            Genre customGenre = title1 + title2;          
            Console.WriteLine("<<<<<<<<<<<<< Created a new genre '{0}' from two titles >>>>>>>>>>>>>",customGenre.name);
            genreList.Add(customGenre);
        }
        public void showGenreOptions()
        {
            int count = 0;
            foreach (Genre g in genreList)
            {
                Console.WriteLine("Enter {0} to see {1}", count, g.name);
                count++;
            }
            int indx = getUserGenre();
            showSpecificGenre(indx);
        }
        private int getUserGenre()
        {
            string genre = Console.ReadLine();
            try
            {
                int indx = Convert.ToInt32(genre);
                return indx;
            }
            catch (FormatException)
            {
            }
            return getUserGenre();
        }
        private void showSpecificGenre(int indx)
        {
            if (indx > genreList.Count)
            {
                Console.WriteLine("\nIndex out of range.\n");
                showGenreOptions();
            }
            else
            {
                foreach (var title in genreList[indx])
                {
                    Console.WriteLine(title);
                }
            }
        }
        private List<Title> getComedyTitles()
        {
            Show show = new Show();
            List<Title> comedyTitles = new List<Title>();
            Title comedy1 = new Film("Airplane", 120, 4.5);
            Title comedy2 = new Film("Monty Python", 130, 4.7);
            Title comedy3 = new Film("Anchorman", 115, 4.6);
            Title comedy4 = new Film("Ace Ventura", 140, 4.8);
            Title comedy5 = new Film("Hot Tub Time Machine", 137, 3.5);
            Title comedy6 = new Show("Always Sunny in Philadelphia", show.getEpisodesList("sunny"));
            Title comedy7 = new Show("Archer", show.getEpisodesList("archer"));
            comedyTitles.Add(comedy1);
            comedyTitles.Add(comedy2);
            comedyTitles.Add(comedy3);
            comedyTitles.Add(comedy4);
            comedyTitles.Add(comedy5);
            comedyTitles.Add(comedy6);
            comedyTitles.Add(comedy7);
            return comedyTitles;
        }
        private List<Title> getActionTitles()
        {
            Show show = new Show();
            List<Title> actionTitles = new List<Title>();
            Title action1 = new Film("Die Hard", 130, 4.6);
            Title action2 = new Film("Rambo", 140, 3.5);
            Title action3 = new Film("Predator", 150, 4.1);
            Title action4 = new Film("Avengers", 110, 3.3);
            Title action5 = new Film("Star Wars", 115, 5.0);
            Title action6 = new Show("Heroes", show.getEpisodesList("heroes"));
            Title action7 = new Show("Homeland", show.getEpisodesList("homeland"));
            actionTitles.Add(action1);
            actionTitles.Add(action2);
            actionTitles.Add(action3);
            actionTitles.Add(action4);
            actionTitles.Add(action5);
            actionTitles.Add(action6);
            actionTitles.Add(action7);
            return actionTitles;
        }
        private List<Title> getRomanceTitles()
        {
            Show show = new Show();
            List<Title> romanceTitles = new List<Title>();
            Title romance1 = new Film("The Notebook", 120, 3.9);
            Title romance2 = new Film("Titanic", 150, 4.5);
            Title romance3 = new Film("Annie Hall", 160, 4.2);
            Title romance4 = new Film("Moonrise Kingdom", 140, 3.3);
            Title romance5 = new Film("Casablanca", 136, 3.6);
            Title romance6 = new Film("Punch Drunk Love", 150, 3.9);
            Title romance7 = new Show("Bones", show.getEpisodesList("bones"));
            Title romance8 = new Show("Sex & the City", show.getEpisodesList("city"));
            romanceTitles.Add(romance1);
            romanceTitles.Add(romance2);
            romanceTitles.Add(romance3);
            romanceTitles.Add(romance4);
            romanceTitles.Add(romance5);
            romanceTitles.Add(romance6);
            romanceTitles.Add(romance7);
            romanceTitles.Add(romance8);
            return romanceTitles;
        }
        private List<Title> getAllTitles()
        {
            List<Title> allTitles = new List<Title>();
            foreach(Title c in getComedyTitles())
            {
                allTitles.Add(c);
            }
            foreach(Title a in getActionTitles())
            {
                allTitles.Add(a);
            }
            foreach(Title r in getRomanceTitles())
            {
                allTitles.Add(r);
            }
            return allTitles;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmCatalogue
{
    public class User
    {
        Catalog catalog;
        public User(Catalog catalog)
        {
            this.catalog = catalog;
            catalog.setGenres();
            showUserOptions();
        }
        private void showUserOptions()
        {
            bool option = true;
            while (option)
            {
                printOptions();
                string choice = Console.ReadLine().ToUpper();
                switch (choice)
                {
                    case "1":
                        viewGenres();
                        break;
                    case "2":
                        viewCatalog();
                        break;
                    case "3":
                        makeNewGenre();
                        break;
                    case "4":
                        viewNewGenre();
                        break;
                    case "5":
                        makeAggregateTitlesGenre();
                        break;
                    case "6":
                        viewCertainGenre();
                        break;
                    case "7":
                        addTitle();
                        break;
                    case "Q":
                        option = false;
                        break;
                }
            }
        }
        private void printOptions()
        {
            Console.WriteLine("Enter 1 to view the Genres.\nEnter 2 to view the catalog.\n"
                + "Enter 3 to aggregate a genre.\nEnter 4 to view your new Genre."
                + "\nEnter 5 to make an aggregated genre from two titles.\nEnter 6 to view a certain genre."
                + "\nEnter 7 to add a title to another Genre.\nEnter Q to quit.");
        }
        private void viewGenres()
        {
            catalog.viewGenres();
        }
        private void viewCatalog()
        {
            foreach(var genreAndTitle in catalog)
            {
                Console.WriteLine(genreAndTitle);
            }          
        }
        private void makeNewGenre()
        {
            Console.WriteLine("Enter the 1st genre you'd like to aggregate.");
            string name = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter the 2nd genre you'd like to aggregate.");
            string name2 = Console.ReadLine().ToUpper();
            Genre genre1 = catalog.genreList.Find(g => g.name == name);
            Genre genre2 = catalog.genreList.Find(g => g.name == name2);
            if (genre1 != null && genre2 != null)
            {
                catalog.makeNewGenre(genre1, genre2);
            }
            else { Console.WriteLine("Try again."); makeNewGenre(); }
        }
        private void viewNewGenre()
        {
            catalog.viewNewGenre();
        }
        private void makeAggregateTitlesGenre()
        {
            List<Title> titles = new List<Title>();
            int count = 1;
            for(int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter Genre #{0} that has the title:", count);
                string stringGenre = Console.ReadLine().ToUpper();
                Genre genre = catalog.genreList.Find(x => x.name == stringGenre);
                if (genre != null)
                {
                    Console.WriteLine("Enter the name of the title:");
                    string stringTitle = Console.ReadLine();
                    Title title = genre.genreTitles.Find(x => x.name == stringTitle);
                    if (title != null)
                    {
                        titles.Add(title);
                        count++;
                    }
                    else { Console.WriteLine("Try again!"); makeAggregateTitlesGenre(); }
                }
                else { Console.WriteLine("Try again!!"); makeAggregateTitlesGenre(); }
            }
            Console.WriteLine("Enter a name for the new Genre:");
            string genreName = Console.ReadLine().ToUpper();
            catalog.aggregateTitles(titles[0], titles[1], genreName);
        }
        private void viewCertainGenre()
        {
            catalog.viewGenres();
            catalog.showGenreOptions();
        }
        private void addTitle()
        {
            Console.WriteLine("Enter the genre that has the title you want to add.");
            string name = Console.ReadLine().ToUpper();
            Genre genre1 = catalog.genreList.Find(g => g.name == name);
            if (genre1 != null)
            {
                Console.WriteLine("What's the title?");
                string title = Console.ReadLine();
                Title title1 = genre1.genreTitles.Find(t => t.name == title);
                if (title1 != null)
                {
                    Console.WriteLine("Enter the genre you'd like to add {0} to.", title1.name);
                    string name2 = Console.ReadLine().ToUpper();
                    Genre genre2 = catalog.genreList.Find(g => g.name == name2);
                    if (genre2 != null)
                    {
                        catalog.addTitleToGenre(genre2, title1);
                    }
                }
            }
            else { addTitle(); }
        }
    }
}

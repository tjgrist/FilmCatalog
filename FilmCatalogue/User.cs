using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmCatalogue
{
    class User
    {
        Catalog catalog;
        public User(Catalog catalog)
        {
            this.catalog = catalog;
            catalog.setGenres();
            showUserOptions();
        }
        //user options
        //add title;
        //
        private void showUserOptions()
        {
            bool option = true;
            while (option)
            {
                printOptions();
                string choice = Console.ReadLine();
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
                    case "Q":
                        option = false;
                        break;
                }
            }
        }
        private void printOptions()
        {
            Console.WriteLine("Enter 1 to view theh Genres.\nEnter 2 to view the catalog.\nEnter 3 to aggregate a genre."
                + "\nEnter 4 to view your new Genre.\nEnter Q to quit.");
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
        public void makeNewGenre()
        {
            Console.WriteLine("Enter the 1st genre you'd like to aggregate.");
            string name = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter the 1st genre you'd like to aggregate.");
            string name2 = Console.ReadLine().ToUpper();
            int index = catalog.genreList.FindIndex(x => x.name == name);
            int index2 = catalog.genreList.FindIndex(x => x.name == name2);
            catalog.makeNewGenre(index, index2);
        }
        public void viewNewGenre()
        {
            catalog.viewNewGenre();
        }
    }
}

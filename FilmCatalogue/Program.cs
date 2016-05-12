using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalog catalog = new Catalog();

            catalog.setGenres();

            foreach (var c in catalog)
            {
                Console.WriteLine(c);
            }
            
            catalog.viewGenreTitles();
            Console.WriteLine("<<<<<<<<<<<<<< making new genre >>>>>>>>>>>>>");
            Console.ReadKey();
            catalog.makeNewGenre("Action Comedy", 0, 1);
            Console.ReadKey();
        }
    }
}

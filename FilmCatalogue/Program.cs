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
            Console.ReadKey();
            foreach (var c in catalog)
            {
                Console.WriteLine(c);
            }          
            Console.WriteLine("<<<<<<<<<<<<<< make a new genre >>>>>>>>>>>>>");
            Console.ReadKey();
            catalog.makeNewGenre("Action Comedy", 0, 1);
            Console.ReadKey();
            foreach (var c in catalog)
            {
                Console.WriteLine(c);
            }
            Console.ReadKey();
            //catalog.addTitleToGenre(catalog.genreList[2], catalog.genreList[1]);
            //catalog.viewGenreTitles();
            //Console.ReadKey();
            //catalog.aggregateTitles();
            //foreach (var c in catalog)
            //{
            //    Console.WriteLine(c);
            //}
            Console.ReadKey();
        }
    }
}

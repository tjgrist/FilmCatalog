﻿using System;
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
            User user = new User(new Catalog());
            //catalog.setGenres();
            //Console.ReadKey();
            //foreach (var c in catalog)
            //{
            //    Console.WriteLine(c);
            //}          

            //Console.ReadKey();
            //catalog.makeNewGenre(0, 1);
            //Console.ReadKey();
            //foreach (var c in catalog)
            //{
            //    Console.WriteLine(c);
            //}
            //Console.ReadKey();
            //catalog.addTitleToGenre(catalog.genreList[2], catalog.genreList[1]);

            //Console.ReadKey();           
            //catalog.aggregateTitles(); //combine two titles and return a new custom genre
            //foreach (var c in catalog)
            //{
            //    Console.WriteLine(c);
            //}
            Console.ReadKey();
        }
    }
}

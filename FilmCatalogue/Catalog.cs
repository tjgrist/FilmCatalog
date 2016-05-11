using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FilmCatalogue
{
    public class Catalog
    {
        
        public void viewGenreTitles()
        {
            Genre genres = new Genre();
            foreach(var g in genres)
            {
                 Console.WriteLine(g);
            }
        }
    }
}
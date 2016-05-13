using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmCatalogue
{
    class User
    {
        //user options
        //add title;
        //
        public void viewCatalog(Catalog catalog)
        {
            foreach(var genreAndTitle in catalog)
            {
                Console.WriteLine(genreAndTitle);
            }          
        }
        public void makeNewGenre()
        {

        }

    }
}

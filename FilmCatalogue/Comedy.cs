using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace FilmCatalogue
{
    class Comedy : Title
    {
        public Comedy(string name, int length, double rating)
        {
            this.name = name;
            this.length = length;
            this.rating = rating;
        }

    }
}

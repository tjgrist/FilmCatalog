using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FilmCatalogue
{
    class Romance : Title
    {
        public Romance(string name, int length, double rating)
        {
            this.name = name;
            this.length = length;
            this.rating = rating;
        }
    }
}
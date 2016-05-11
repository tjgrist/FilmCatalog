using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmCatalogue
{
    class Action : Title
    {
        public Action(string name, int length, double rating)
        {
            this.name = name;
            this.length = length;
            this.rating = rating;
        }
    }
}

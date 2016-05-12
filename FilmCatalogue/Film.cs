using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmCatalogue
{
    public class Film : Title
    {
        public int? length;
        public Film(string name, int length, double rating)
        {
            this.name = name;
            this.length = length;
            this.rating = rating;
        }
        public override string ToString()
        {
            return name + " " + length + "min.";
        }

    }
}

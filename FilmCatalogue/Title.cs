using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmCatalogue
{
    public class Title
    {
        public string name;
        public int length;
        public double rating;

        public Title(string name, int length, double rating)
        {
            this.name = name;
            this.length = length;
            this.rating = rating;
        }
    }
}

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
        public double ?rating;

        public Title(string name, double rating)
        {
            this.name = name;
            this.rating = rating;
        }
        public Title()
        {
            name = null;
            rating = null;
        }
        public static Genre operator +(Title title1, Title title2)
        {
            List<Title> newTitleList = new List<Title>() { title1, title2 };
            return new Genre("Custom Genre", newTitleList);
        }
    }
}

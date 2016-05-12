using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace FilmCatalogue
{
    public class Genre : IEnumerable
    {
        public string name;
        public List<Title> genreTitles;

        public Genre(string name, List<Title> titleList)
        {
            this.name = name.ToUpper();
            genreTitles = titleList;
        }

        public IEnumerator GetEnumerator()
        {
            foreach(Title t in genreTitles)
            {
                yield return t.name;
                yield return "Duration: " + t.length;
                yield return "Rating: " + t.rating + "\n";
            }
        }
        public static Genre operator +(Genre genre1, Genre genre2)
        {
            foreach(Title t in genre2.genreTitles)
            {
                genre1.genreTitles.Add(t);              
            }
            return genre1;
        }
    }
}

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
                yield return "Rating: " + t.rating + "\n";
            }
        }
        public static Genre operator +(Genre genre1, Genre genre2)
        {
            string newName = genre1.name + " " + genre2.name;
            List<Title> newGenreList = genre1.genreTitles;
            foreach(Title t in genre2.genreTitles)
            {
                newGenreList.Add(t);              
            }
            return new Genre(newName, newGenreList);
        }
        public static List<Title> operator +(Genre genre, Title title)
        {
            genre.genreTitles.Add(title);
            return genre.genreTitles;
        }
    }
}

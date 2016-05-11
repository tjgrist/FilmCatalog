using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace FilmCatalogue
{
    class Genre : IEnumerable
    {
        Title title = new Title();
        public IEnumerator GetEnumerator()
        {
            title.setComedyTitles();
            Console.WriteLine("Comedies:");
            foreach(Comedy c in title.ComedyTitles)
            {
                yield return c.name;
                yield return "Duration: " + c.length;
                yield return "Rating: " + c.rating + "\n";
            }
            Console.WriteLine("Action:");
            foreach(Action a in title.actionTitles)
            {
                yield return a.name;
                yield return "Duration: " + a.length;
                yield return "Rating: " + a.rating + "\n";
            }
            Console.WriteLine("Romance:");
            foreach (Romance r in title.romanceTitles)
            {
                yield return r.name;
                yield return "Duration: " + r.length;
                yield return "Rating: " + r.rating + "\n";
            }
        }
    }
}

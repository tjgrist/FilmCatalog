using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace FilmCatalogue
{
    class Comedy : Title, IEnumerable
    {
        public List<Comedy> comedies = new List<Comedy>();

        public IEnumerator GetEnumerator()
        {
            foreach (Comedy comedy in comedies)
            {
                yield return comedy.title;
                yield return comedy.length;
            }
        }
    }
}

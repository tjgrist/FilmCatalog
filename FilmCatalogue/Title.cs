using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmCatalogue
{
    class Title
    {
        public string name;
        public int length;
        public double rating;

        public List<Comedy> comedyTitles = new List<Comedy>();
        public List<Action> actionTitles = new List<Action>();
        public List<Romance> romanceTitles = new List<Romance>();

        public List<Comedy> ComedyTitles{ get { return comedyTitles; } }

        public void setTitles()
        {
            setComedyTitles();
            setActionTitles();
            setRomanceTitles();
        }
        public void setComedyTitles()
        {
            Comedy comedy1 = new Comedy("Airplane", 120, 4.5);
            Comedy comedy2 = new Comedy("Monty Python", 130, 4.7);
            Comedy comedy3 = new Comedy("Anchorman", 150, 4.6);
            Comedy comedy4 = new Comedy("Ace ventura", 110, 4.8);
            Comedy comedy5 = new Comedy("Hot tub Time Machine", 134, 3.5);
            comedyTitles.Add(comedy1);
            comedyTitles.Add(comedy2);
            comedyTitles.Add(comedy3);
            comedyTitles.Add(comedy4);
            comedyTitles.Add(comedy5);
        }
        private void setActionTitles()
        {
            Action action1 = new Action("Die Hard", 145, 4.6);
        }
        private void setRomanceTitles()
        {
            Romance romance1 = new Romance("The Notebook", 200, 3.9);
        }
    }
}

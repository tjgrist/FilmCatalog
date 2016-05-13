using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmCatalogue
{
    public class Show : Title
    {
        List<Episodes> episodesList;
        public Show(string name, List<Episodes> episodes)
        {
            this.name = name;
            episodesList = episodes;
        }
        public Show() {}
        public override double Rating
        {
            get
            {
                double averageRating = 0;
                foreach (Episodes e in episodesList)
                {
                    averageRating += (double)e.rating;
                }
                rating = averageRating / episodesList.Count;
                return (double)rating;
            }
        }
        public override string ToString()
        {
            return name + "\nEpisodes: " + episodesList.Count;
        }
        public List<Episodes> getEpisodesList(string showName)
        {
            List<Episodes> episodes = new List<Episodes>();
            switch (showName)
            {
                case "archer":
                    Episodes episode1 = new Episodes(4.4);
                    Episodes episode2 = new Episodes(3.9);
                    Episodes episode3 = new Episodes(4.6);
                    Episodes episode32 = new Episodes(4.1);
                    Episodes episode33 = new Episodes(4.9);
                    Episodes episode34 = new Episodes(4.6);
                    episodes.Add(episode1);
                    episodes.Add(episode2);
                    episodes.Add(episode3);
                    episodes.Add(episode32);
                    episodes.Add(episode33);
                    episodes.Add(episode34);
                    break;
                case "sunny":
                    Episodes episode4 = new Episodes(3.4);
                    Episodes episode5 = new Episodes(4.5);
                    Episodes episode6 = new Episodes(3.8);
                    Episodes episode29 = new Episodes(3.2);
                    Episodes episode30 = new Episodes(4.9);
                    Episodes episode31 = new Episodes(4.0);
                    episodes.Add(episode4);
                    episodes.Add(episode5);
                    episodes.Add(episode6);
                    episodes.Add(episode29);
                    episodes.Add(episode30);
                    episodes.Add(episode31);
                    break;
                case "bones":
                    Episodes episode7 = new Episodes(4.1);
                    Episodes episode8 = new Episodes(3.9);
                    Episodes episode9 = new Episodes(4.4);
                    Episodes episode10 = new Episodes(4.5);
                    Episodes episode11 = new Episodes(4.7);
                    Episodes episode12 = new Episodes(3.6);
                    episodes.Add(episode7);
                    episodes.Add(episode8);
                    episodes.Add(episode9);
                    episodes.Add(episode10);
                    episodes.Add(episode11);
                    episodes.Add(episode12);
                    break;
                case "city":
                    Episodes episode13 = new Episodes(3.9);
                    Episodes episode14 = new Episodes(4.5);
                    Episodes episode15 = new Episodes(3.2);
                    Episodes episode16 = new Episodes(4.3);
                    Episodes episode17 = new Episodes(2.0);
                    Episodes episode18 = new Episodes(3.1);
                    Episodes episode19 = new Episodes(3.9);
                    Episodes episode20 = new Episodes(4.8);
                    Episodes episode21 = new Episodes(4.3);
                    Episodes episode22 = new Episodes(2.1);
                    episodes.Add(episode13);
                    episodes.Add(episode14);
                    episodes.Add(episode15);
                    episodes.Add(episode16);
                    episodes.Add(episode17);
                    episodes.Add(episode18);
                    episodes.Add(episode19);
                    episodes.Add(episode20);
                    episodes.Add(episode21);
                    episodes.Add(episode22);
                    break;
                  case "heroes":
                    Episodes episode23 = new Episodes(3.8);
                    Episodes episode24 = new Episodes(4.3);
                    Episodes episode25 = new Episodes(4.1);
                    Episodes episode26 = new Episodes(3.7);
                    Episodes episode27 = new Episodes(4.8);
                    Episodes episode28 = new Episodes(4.2);
                    episodes.Add(episode23);
                    episodes.Add(episode24);
                    episodes.Add(episode25);
                    episodes.Add(episode26);
                    episodes.Add(episode27);
                    episodes.Add(episode28);
                    break;
                case "homeland":
                    Episodes episode35 = new Episodes(4.2);
                    Episodes episode36 = new Episodes(3.9);
                    Episodes episode37 = new Episodes(4.5);
                    Episodes episode38 = new Episodes(3.7);
                    Episodes episode39 = new Episodes(3.9);
                    Episodes episode40 = new Episodes(4.3);
                    Episodes episode41 = new Episodes(2.9);
                    episodes.Add(episode35);
                    episodes.Add(episode36);
                    episodes.Add(episode37);
                    episodes.Add(episode38);
                    episodes.Add(episode39);
                    episodes.Add(episode40);
                    episodes.Add(episode41);
                    break;
                default:
                    break; //will break program;
            }
            return episodes;
        }
    }
}

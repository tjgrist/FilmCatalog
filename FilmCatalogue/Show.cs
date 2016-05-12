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
        public List<Episodes> getEpisodesList(string name)
        {
            List<Episodes> episodes = new List<Episodes>();
            switch (name)
            {
                case "archer":
                    Episodes episode1 = new Episodes(4.4);
                    Episodes episode2 = new Episodes(3.9);
                    Episodes episode3 = new Episodes(4.6);
                    episodes.Add(episode1);
                    episodes.Add(episode2);
                    episodes.Add(episode3);
                    break;
                case "sunny":
                    Episodes episode4 = new Episodes(3.4);
                    Episodes episode5 = new Episodes(4.5);
                    Episodes episode6 = new Episodes(3.8);
                    episodes.Add(episode4);
                    episodes.Add(episode5);
                    episodes.Add(episode6);
                    break;
                case "bones":
                    Episodes episode7 = new Episodes(4.1);
                    Episodes episode8 = new Episodes(3.9);
                    Episodes episode9 = new Episodes(4.4);
                    episodes.Add(episode7);
                    episodes.Add(episode8);
                    episodes.Add(episode9);
                    break;
                case "heroes":
                    Episodes episode10 = new Episodes(3.8);
                    Episodes episode11 = new Episodes(4.3);
                    Episodes episode12 = new Episodes(4.1);
                    episodes.Add(episode10);
                    episodes.Add(episode11);
                    episodes.Add(episode12);
                    break;
                case "city":
                    Episodes episode13 = new Episodes(3.9);
                    Episodes episode14 = new Episodes(4.5);
                    Episodes episode15 = new Episodes(3.2);
                    episodes.Add(episode13);
                    episodes.Add(episode14);
                    episodes.Add(episode15);
                    break;
                default:
                    break; //will break program;
            }
            return episodes;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeList
{
    public class Anime
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Type { get; set; }
        public int Episodes { get; set; }
        public DateTime ReleaseDate { get; set; }
        public bool Status { get; set; }
        public string Synopsis { get; set; }
        public Anime(string title, string genre, DateTime dt, string synopsis)
        {
            
        }

        public Anime(string title, string genre, string type, int episodes, DateTime releaseDate, bool status, string synopsis)
        {
            Title = title;
            Genre = genre;
            Type = type;
            Episodes = episodes;
            ReleaseDate = releaseDate;
            Status = status;
            Synopsis = synopsis;
        }
    }
}

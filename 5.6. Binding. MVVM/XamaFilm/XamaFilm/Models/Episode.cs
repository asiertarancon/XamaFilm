using System;
using System.Collections.Generic;
using System.Text;

namespace XamaFilm.Models
{
    public class Episode : Item
    {
        public string SerieId { get; set; }
        public string SeasonNumber { get; set; }
        public string EpisodeNumber { get; set; }

    }
}

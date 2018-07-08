using System;
using System.Collections.Generic;
using System.Text;

namespace XamaFilm.Models
{
    public class Season
    {
        public string Title { get; set; }

        public string TotalSeasons { get; set; }

        public string SeasonNumber { get; set; }

        public List<SeasonEpisode> Episodes { get; set; }
        
    }
}

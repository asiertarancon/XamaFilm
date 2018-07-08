using System;
using System.Collections.Generic;
using System.Text;

namespace XamaFilm.Models
{
    public class Search
    {
        public string Title { get; set; }

        public string Year { get; set; }

        public string ImdbID { get; set; }

        public string Type { get; set; }
        
        public string Poster { get; set; }
    }
}

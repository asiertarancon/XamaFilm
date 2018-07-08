using System;
using System.Collections.Generic;
using System.Text;

namespace XamaFilm.Models
{
    public class Movie : Item
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}

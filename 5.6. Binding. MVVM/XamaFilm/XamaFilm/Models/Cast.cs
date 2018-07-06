using System;
using System.Collections.Generic;
using System.Text;

namespace XamaFilm.Models
{
    public class Cast
    {        
        public int CastId { get; set; }
        public string Character { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
        public string ProfilePath { get; set; }
        public PersonGender Gender { get; set; }
    }

    public enum PersonGender
    {        
        Unknown = 0,
        Female = 1,
        Male = 2
    }
}

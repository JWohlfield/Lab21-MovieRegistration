using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRegistration.Models
{
    public enum Genre { Action, Children, Comedy, Drama, Horror, SciFi }
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public int Year { get; set; }
        public string Actors { get; set; }
        public string Director { get; set; }
    }
}

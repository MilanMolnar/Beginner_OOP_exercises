using System;
using System.Collections.Generic;
using System.Text;

namespace _18_GetterSetter
{
    class Movie
    {
        public string title;
        public string director;
        private string rating;

        public Movie(string Atitle, string Adirector, string Arating)
        {
            title = Atitle;
            director = Adirector;
            rating = Arating;
        }
        public string Rating
        {
            get { return rating; }
            set {
                    if (value == "G" || value == "PG" || value == "R")
                    {
                        rating = value;
                    }
                    rating = "NR";
                }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week05ImdbList
{
    internal class Movie
    {
        public string Title { get; set; }
        public double ImdbRating { get; set; }

        public Movie(string title, double imdbRating)
        {
            Title = title;
            ImdbRating = imdbRating;
        }
    }
}

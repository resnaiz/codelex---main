using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_4
{
    internal class Movie
    {
        public string title;
        public string studio;
        public string rating;

        public Movie(string movieTitle, string movieStudio, string movieRating)
        {
            this.title = movieTitle;
            this.studio = movieStudio;
            this.rating = movieRating;
        }

        public Movie(string movieTitle, string movieStudio)
        {
            this.title = movieTitle;
            this.studio = movieStudio;
        }

        public static Movie[] GetPG(Movie[] movies)
        {
            Movie[] moviesWithPG = new Movie[movies.Length];
            int counter = 0;

            foreach(Movie oneMovie in movies)
            {
                if(oneMovie.rating == "PG")
                {
                    moviesWithPG[counter] = oneMovie;
                    counter++;
                }
            }

            Array.Resize(ref moviesWithPG, counter);
            return moviesWithPG;
        }
    }
}

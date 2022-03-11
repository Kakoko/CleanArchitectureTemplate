using CleanMovie.Application;
using CleanMovie.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Infrastructure
{
    public class MovieRepository : IMovieRepository
    {
        public static List<Movie> movies = new List<Movie>()
        {
            new Movie {Id = 1 , Name = "Passion of Christ" , Cost = 2},
            new Movie {Id = 2 , Name = "Home Alone 4" , Cost = 1}
        };
        public List<Movie> GetAllMovies()
        {
            return movies;
        }
    }
}

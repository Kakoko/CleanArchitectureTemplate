using CleanMovie.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Application
{

    //This is a use case
    public  interface IMovieService
    {
        List<Movie> GetAllMovies();

        Movie CreateMovie(Movie movie);
    }
}

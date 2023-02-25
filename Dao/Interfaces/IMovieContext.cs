using System.Collections.Generic;
using MovieManager.Models;

namespace MovieManager.Dao.Interfaces;

public interface IMovieContext
{
    List<Movie> Movies { get; set; }
}

using System.Collections.Generic;
using MovieManager.Models;

namespace MovieManager.Dao;

public interface IMovieContext
{
    List<Movie> Movies { get; set; }
}
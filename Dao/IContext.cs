using System.Collections.Generic;
using MovieManager.Models;

namespace MovieManager.Dao;

public interface IContext
{
    List<Movie> Movies { get; set; }
    List<Show> Shows { get; set; }
    List<Video> Videos { get; set; }
}

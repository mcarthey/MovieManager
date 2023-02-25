using System.Collections.Generic;
using MovieManager.Models;

namespace MovieManager.Dao;

public interface IShowContext
{
    List<Show> Shows { get; set; }
}

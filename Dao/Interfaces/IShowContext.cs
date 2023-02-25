using System.Collections.Generic;
using MovieManager.Models;

namespace MovieManager.Dao.Interfaces;

public interface IShowContext
{
    List<Show> Shows { get; set; }
}

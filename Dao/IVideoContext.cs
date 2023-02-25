using System.Collections.Generic;
using MovieManager.Models;

namespace MovieManager.Dao;

public interface IVideoContext
{
    List<Video> Videos { get; set; }
}

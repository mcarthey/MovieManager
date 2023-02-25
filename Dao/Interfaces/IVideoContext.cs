using System.Collections.Generic;
using MovieManager.Models;

namespace MovieManager.Dao.Interfaces;

public interface IVideoContext
{
    List<Video> Videos { get; set; }
}

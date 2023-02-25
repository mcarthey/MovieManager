using System.Collections.Generic;
using MovieManager.Models;

namespace MovieManager.Dao;

public interface IRepository
{
    void Add(Media media);
    IEnumerable<Media> Find(string id);

    IEnumerable<Media> GetAll();
    Media GetByTitle(string title);
}

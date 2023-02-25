using System.Collections.Generic;
using System.Linq;
using MovieManager.Dao.Interfaces;
using MovieManager.Models;

namespace MovieManager.Dao;

public class MovieRepository : IRepository
{
    private readonly IMovieContext _movieContext;

    public MovieRepository(IMovieContext movieContext)
    {
        _movieContext = movieContext;
    }

    public void Add(Media media)
    {
        _movieContext.Movies.Add((Movie) media);
    }

    public IEnumerable<Media> Find(string id)
    {
        return _movieContext.Movies.Where(x => x.Id == id);
    }

    public IEnumerable<Media> GetAll()
    {
        return _movieContext.Movies;
    }

    public Media GetByTitle(string title)
    {
        return _movieContext.Movies.FirstOrDefault(x => x.Title == title);
    }
}

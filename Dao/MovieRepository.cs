using System.Collections.Generic;
using System.Linq;
using MovieManager.Models;

namespace MovieManager.Dao;

public class MovieRepository : IRepository
{
    private readonly IContext _context;

    public MovieRepository(IContext context)
    {
        _context = context;
    }

    public void Add(Media media)
    {
        _context.Movies.Add((Movie) media);
    }

    public IEnumerable<Media> Find(string id)
    {
        return _context.Movies.Where(x => x.Id == id);
    }

    public IEnumerable<Media> GetAll()
    {
        return _context.Movies;
    }

    public Media GetByTitle(string title)
    {
        return _context.Movies.FirstOrDefault(x => x.Title == title);
    }
}

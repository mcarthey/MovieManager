using System.Collections.Generic;
using Faker;
using MovieManager.Dao.Interfaces;
using MovieManager.Models;

namespace MovieManager.Dao;

public class MovieContext : IMovieContext
{
    public MovieContext()
    {
        PopulateMovies();
    }

    public List<Movie> Movies { get; set; }

    private void PopulateMovies()
    {
        Movies = new List<Movie>();
        for (var i = 0; i < 5; i++)
        {
            var movie = new Movie
            {
                Title = Lorem.Sentence(),
                Year = RandomNumber.Next(1900, 2023).ToString(),
                Theater = Company.Name()
            };
            Movies.Add(movie);
        }
    }
}

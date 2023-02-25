using System.Collections.Generic;
using Faker;
using MovieManager.Models;

namespace MovieManager.Dao;

public class MediaContext : IContext
{
    public MediaContext()
    {
        PopulateMovies();
        PopulateShows();
        PopulateVideos();
    }

    public List<Movie> Movies { get; set; }
    public List<Show> Shows { get; set; }
    public List<Video> Videos { get; set; }

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

    private void PopulateShows()
    {
        Shows = new List<Show>();
        for (var i = 0; i < 5; i++)
        {
            var show = new Show
            {
                Title = Lorem.Sentence(),
                Year = RandomNumber.Next(1900, 2023).ToString(),
                Network = Company.CatchPhrase()
            };
            Shows.Add(show);
        }
    }

    private void PopulateVideos()
    {
        Videos = new List<Video>();
        for (var i = 0; i < 5; i++)
        {
            var video = new Video
            {
                Title = Lorem.Sentence(),
                Year = RandomNumber.Next(1900, 2023).ToString(),
                Format = Company.BS()
            };
            Videos.Add(video);
        }
    }
}

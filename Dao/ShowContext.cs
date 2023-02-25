using System.Collections.Generic;
using Faker;
using MovieManager.Dao.Interfaces;
using MovieManager.Models;

namespace MovieManager.Dao;

public class ShowContext : IShowContext
{
    public ShowContext()
    {
        PopulateShows();
    }

    public List<Show> Shows { get; set; }

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
}

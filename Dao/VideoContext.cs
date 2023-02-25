using System.Collections.Generic;
using Faker;
using MovieManager.Dao.Interfaces;
using MovieManager.Models;

namespace MovieManager.Dao;

public class VideoContext : IVideoContext
{
    public VideoContext()
    {
        PopulateVideos();
    }

    public List<Video> Videos { get; set; }

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

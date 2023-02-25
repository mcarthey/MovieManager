using System;
using System.Linq;
using MovieManager.Dao.Interfaces;
using MovieManager.Helpers;
using MovieManager.Models;
using Spectre.Console;

namespace MovieManager.Services;

public class MainService : IMainService
{
    private readonly IRepository _repository;

    public MainService(IRepository repository)
    {
        _repository = repository;
    }

    public void Invoke()
    {
        string choice = null;

        while (choice != "Exit")
        {
            choice = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("Select your [green]option[/]?")
                    .MoreChoicesText("[grey](Arrow up and down to select)[/]")
                    .AddChoices("Add", "Find", "List", "Exit"));

            switch (choice)
            {
                case "Add":
                    var title = MenuHelper.GetStringInput("title");
                    var year = MenuHelper.GetYearInput();
                    var theater = MenuHelper.GetStringInput("theater");

                    var movie = new Movie
                    {
                        Title = title,
                        Year = year.ToString(),
                        Theater = theater
                    };
                    _repository.Add(movie);

                    break;

                case "Find":
                    title = MenuHelper.GetStringInput("title");
                    movie = (Movie) _repository.GetByTitle(title);
                    Console.WriteLine(movie);

                    break;

                case "List":
                    var movies = _repository.GetAll().ToList();
                    movies.ForEach(Console.WriteLine);

                    break;
                case "Exit":
                    break;
            }
        }
    }
}

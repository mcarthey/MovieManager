using Spectre.Console;

namespace MovieManager.Helpers;

public static class MenuHelper
{
    public static string GetStringInput(string inputName)
    {
        return AnsiConsole.Prompt(
            new TextPrompt<string>($"What is the movie [green]{inputName}[/]?")
                .PromptStyle("green")
        );
    }

    public static int GetYearInput()
    {
        return AnsiConsole.Prompt(
            new TextPrompt<int>("What [green]year[/] was the movie released?")
                .PromptStyle("green")
                .ValidationErrorMessage("[red]That's not a valid year[/]")
                .Validate(age =>
                {
                    return age switch
                    {
                        <= 1900 => ValidationResult.Error("[red]The year must be after 1900[/]"),
                        >= 2023 => ValidationResult.Error("[red]The year must be before 2023[/]"),
                        _ => ValidationResult.Success()
                    };
                }));
    }
}

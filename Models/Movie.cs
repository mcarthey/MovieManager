namespace MovieManager.Models;

public class Movie : Media
{
    public string Theater { get; set; }

    public override string ToString()
    {
        return $"Title: {Title}, Year: {Year}, Theater: {Theater}";
    }
}

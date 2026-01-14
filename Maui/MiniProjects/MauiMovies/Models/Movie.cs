namespace MauiMovies.Models;

public class Movie
{
    public string Title { get; set; } = "";
    public double Rating { get; set; }
    public string? Poster { get; set; }
    public string Genre { get; set; }

// used onlyb on details page
    public int Year { get; set; }
    public string Director { get; set; }
    public string Description { get; set; }
}
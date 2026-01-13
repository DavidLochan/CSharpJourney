namespace MauiMovies.Models;

public class Movie
{
    public string Title { get; set; } = "";
    public double Rating { get; set; }
    public string? Poster { get; set; }
    public string Genre { get; set; }
}
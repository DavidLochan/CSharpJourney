using MauiMovies.Models;

namespace MauiMovies;

[QueryProperty(nameof(Movie), "Movie")]
public partial class MovieDetailsPage : ContentPage
{
    private Movie _movie;

    public Movie Movie
    {
        get => _movie;
        set
        {
            _movie = value;
            BindingContext = value;
        }
    }

    public MovieDetailsPage()
    {
        InitializeComponent();
    }
}
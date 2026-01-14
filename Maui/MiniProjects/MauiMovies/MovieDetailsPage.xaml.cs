using MauiMovies.Models;

namespace MauiMovies;

public partial class MovieDetailsPage : ContentPage
{
    public MovieDetailsPage(Movie movie)
    {
        InitializeComponent();
        BindingContext = movie;
    }
}
using MauiMovies.Models;
using MauiMovies.Services;
using System.Collections.ObjectModel;

namespace MauiMovies.ViewModels;

public class MoviesViewModel
{
    private readonly IMovieService _movieService;

    public ObservableCollection<Movie> Movies { get; } = new();

    public MoviesViewModel(IMovieService movieService)
    {
        _movieService = movieService;
    }

    public async Task LoadMoviesAsync()
    {
        var movies = await _movieService.GetTrendingMoviesAsync();

        Movies.Clear();
        foreach (var movie in movies)
            Movies.Add(movie);
    }
}
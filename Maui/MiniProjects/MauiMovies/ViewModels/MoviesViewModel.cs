using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using MauiMovies.Models;
using MauiMovies.Services;

namespace MauiMovies.ViewModels;

public class MoviesViewModel : INotifyPropertyChanged
{
    private readonly IMovieService _movieService;

    public ObservableCollection<Movie> Movies { get; } = new();

    private bool _isLoading;
    public bool IsLoading
    {
        get => _isLoading;
        set
        {
            _isLoading = value;
            OnPropertyChanged();
        }
    }

    public MoviesViewModel(IMovieService movieService)
    {
        _movieService = movieService;
    }

    public async Task LoadMoviesAsync()
    {
        if (IsLoading) return;

        IsLoading = true;
        Movies.Clear();

        var movies = await _movieService.GetTrendingMoviesAsync();
        foreach (var movie in movies)
            Movies.Add(movie);

        IsLoading = false;
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string? name = null)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}
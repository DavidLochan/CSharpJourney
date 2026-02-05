using System.Collections.ObjectModel;
using MauiMovies.Models;
using MauiMovies.Services;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MauiMovies.ViewModels;

public class MoviesViewModel : INotifyPropertyChanged
{
    private readonly IMovieService _movieService;
    private List<Movie> _allMovies = new();

    public ObservableCollection<Movie> Movies { get; } = new();
    public ObservableCollection<string> Genres { get; } = new() { "All", "Trending" };

    private Movie? _selectedMovie;
    public Movie? SelectedMovie
    {
        get => _selectedMovie;
        set
        {
            _selectedMovie = value;
            OnPropertyChanged();
            IsPopupVisible = value != null;
        }
    }

    private bool _isPopupVisible;
    public bool IsPopupVisible
    {
        get => _isPopupVisible;
        set
        {
            _isPopupVisible = value;
            OnPropertyChanged();
        }
    }

    private string _selectedGenre = "All";
    public string SelectedGenre
    {
        get => _selectedGenre;
        set
        {
            _selectedGenre = value;
            OnPropertyChanged();
            ApplyGenreFilter();
        }
    }

    public MoviesViewModel(IMovieService movieService)
    {
        _movieService = movieService;
        System.Diagnostics.Debug.WriteLine("✨ MoviesViewModel created");
    }

    public async Task LoadMoviesAsync()
    {
        try
        {
            System.Diagnostics.Debug.WriteLine("🔄 LoadMoviesAsync called");
            
            var movies = await _movieService.GetTrendingMoviesAsync();

            System.Diagnostics.Debug.WriteLine($"📦 Received {movies.Count} movies from service");

            Movies.Clear();
            foreach (var movie in movies)
            {
                Movies.Add(movie);
                System.Diagnostics.Debug.WriteLine($"  ➕ Added: {movie.Title}");
            }

            _allMovies = movies;
            
            System.Diagnostics.Debug.WriteLine($"✅ Movies.Count is now: {Movies.Count}");
            OnPropertyChanged(nameof(Movies));  // Force UI update
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine($"❌ Error in LoadMoviesAsync: {ex.Message}");
            System.Diagnostics.Debug.WriteLine($"   Stack: {ex.StackTrace}");
        }
    }

    private void ApplyGenreFilter()
    {
        Movies.Clear();

        var filtered = SelectedGenre == "All"
            ? _allMovies
            : _allMovies.Where(m => m.Genre == SelectedGenre);

        foreach (var movie in filtered)
            Movies.Add(movie);
        
        System.Diagnostics.Debug.WriteLine($"🔍 Filtered to {Movies.Count} movies for genre '{SelectedGenre}'");
    }
 // commit testing
    public event PropertyChangedEventHandler? PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string name = "")
    {
        System.Diagnostics.Debug.WriteLine($"🔔 Property changed: {name}");
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
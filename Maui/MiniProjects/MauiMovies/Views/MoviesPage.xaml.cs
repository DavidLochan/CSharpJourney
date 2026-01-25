using MauiMovies.Models;
using MauiMovies.Services;
using System.Collections.ObjectModel;

namespace MauiMovies.Views;

public partial class MoviesPage : ContentPage
{
    private readonly IMovieService _movieService;
    
    public ObservableCollection<Movie> Movies { get; set; }
    private List<Movie> _allMovies;

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

    public MoviesPage(IMovieService movieService)
    {
        InitializeComponent();
        _movieService = movieService;

     Movies = new ObservableCollection<Movie>();
        _allMovies = new List<Movie>();

        BindingContext = this;
        
        System.Diagnostics.Debug.WriteLine("MoviesPage created");
    }

    private async Task LoadMovies()
    {
        try
        {
            System.Diagnostics.Debug.WriteLine("Loading movies...");
            
            var movies = await _movieService.GetTrendingMoviesAsync();

            System.Diagnostics.Debug.WriteLine($"Received {movies.Count} movies");

            Movies.Clear();
            foreach (var movie in movies)
            {
                Movies.Add(movie);
            }

            _allMovies = Movies.ToList();
            
            System.Diagnostics.Debug.WriteLine($"Movies collection now has {Movies.Count} items");
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine($"LoadMovies error: {ex.Message}");
            await DisplayAlert("Error", $"Failed to load movies: {ex.Message}", "OK");
        }
    }

    private async void OnPointerEntered(object sender, PointerEventArgs e)
    {
        if (sender is VisualElement element)
        {
            await Task.WhenAll(
                element.ScaleTo(1.05, 200, Easing.CubicOut),
                element.FadeTo(1.0, 200)
            );
        }
    }

    private async void OnPointerExited(object sender, PointerEventArgs e)
    {
        if (sender is VisualElement element)
        {
            await Task.WhenAll(
                element.ScaleTo(1.0, 200, Easing.CubicOut),
                element.FadeTo(0.9, 200)
            );
        }
    }

    private async void OnMovieTapped(object sender, EventArgs e)
    {
        if (sender is BindableObject bindable && bindable.BindingContext is Movie movie)
        {
            await Shell.Current.GoToAsync($"{nameof(MovieDetailsPage)}?id={movie.Id}");
        }
    }

    private void ClosePopup(object sender, EventArgs e)
    {
        SelectedMovie = null;
    }

    public ObservableCollection<string> Genres { get; } = new();

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

    private void ApplyGenreFilter()
    {
        Movies.Clear();

        var filtered = SelectedGenre == "All"
            ? _allMovies
            : _allMovies.Where(m => m.Genre == SelectedGenre);

        foreach (var movie in filtered)
            Movies.Add(movie);
    }

    private void OnGenreClicked(object sender, EventArgs e)
    {
        if (sender is Button btn)
            SelectedGenre = btn.Text;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        
        System.Diagnostics.Debug.WriteLine("OnAppearing called");
        
        if (Movies.Count == 0)
        {
            await LoadMovies();
        }
    }
}
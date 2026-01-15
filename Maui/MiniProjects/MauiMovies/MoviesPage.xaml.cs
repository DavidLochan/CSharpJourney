using MauiMovies.Models;
using System.Net.Http.Json;
using System.Collections.ObjectModel;

namespace MauiMovies;

public partial class MoviesPage : ContentPage
{
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

   private HttpClient _httpClient;

    public MoviesPage()
    {
        InitializeComponent();

      Movies = new ObservableCollection<Movie>();
       _allMovies = new List<Movie>();

    _httpClient = new HttpClient
    {
        BaseAddress = new Uri(AppSecrets.TmdbBaseUrl)
    };

    BindingContext = this;
}

    private async Task LoadMovies()
{
    var url = $"trending/movie/week?api_key={AppSecrets.TmdbApiKey}";

    var response =
        await _httpClient.GetFromJsonAsync<TrendingMovies>(url);

    if (response?.results == null)
        return;

    Movies.Clear();

    foreach (var m in response.results)
    {
        Movies.Add(new Movie
        {
            Title = m.title,
            Rating = m.vote_average,
            Poster = $"https://image.tmdb.org/t/p/w500{m.poster_path}",
            Genre = "Trending"
        });
    }

    _allMovies = Movies.ToList();
}

	private async void OnPointerEntered(object sender, PointerEventArgs e)
    {
        if (sender is VisualElement element)
        {
            // Animate scale up and brighten
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
            // Animate scale back to normal
            await Task.WhenAll(
                element.ScaleTo(1.0, 200, Easing.CubicOut),
                element.FadeTo(0.9, 200)
            );
        }
    }
	// Logic for selecting a movie
    private async void OnMovieTapped(object sender, EventArgs e)
   {
    if (sender is BindableObject bindable &&
        bindable.BindingContext is Movie movie)
    {
        await Shell.Current.GoToAsync(
    nameof(MovieDetailsPage),
    new Dictionary<string, object>
    {
        { "Movie", movie }
    }
);
    }
    }
    // Logic for closing the popup
    private void ClosePopup(object sender, EventArgs e) // Added parameters here!
    {
        SelectedMovie = null;
    }
	  public ObservableCollection<string> Genres { get; } =
    new() { "All", "Sci-Fi", "Action", "Drama" };

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
    await LoadMovies();
}

}
using MauiMovies.Models;
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

    public MoviesPage()
    {
        InitializeComponent();

        Movies = new ObservableCollection<Movie>
        {
        new Movie { Title="Inception", Rating=8.8, Poster="movie1.jpg", Genre="Sci-Fi" },
        new Movie { Title="Interstellar", Rating=8.6, Poster="movie2.jpg", Genre="Sci-Fi" },
        new Movie { Title="Dune", Rating=8.2, Poster="movie3.jpg", Genre="Sci-Fi" },
		new Movie { Title="The Dark Knight", Rating=9.0, Poster="movie4.jpg", Genre="Action" },
        new Movie { Title="Blade Runner 2049", Rating=8.1, Poster="movie5.jpg", Genre="Sci-Fi" },
        new Movie { Title="Tenet", Rating=7.8, Poster="movie6.jpg", Genre="Action" },
        new Movie { Title="Arrival", Rating=7.9, Poster="movie7.jpg", Genre="Sci-Fi" },
        new Movie { Title="The Matrix", Rating=8.7, Poster="movie8.jpg", Genre="Sci-Fi" },
        new Movie { Title="Avatar", Rating=7.8, Poster="movie9.jpg", Genre="Sci-Fi" },
        new Movie { Title="Gravity", Rating=7.7, Poster="movie10.jpg", Genre="Sci-Fi" },

        new Movie { Title="Oppenheimer", Rating=8.9, Poster="movie11.jpg", Genre="Drama" },
        new Movie { Title="The Prestige", Rating=8.5, Poster="movie12.jpg", Genre="Drama" },
        new Movie { Title="Ex Machina", Rating=7.7, Poster="movie13.jpg", Genre="Sci-Fi" },
        new Movie { Title="Mad Max Fury Road", Rating=8.1, Poster="movie14.jpg", Genre="Action" },
        new Movie { Title="Her", Rating=8.0, Poster="movie15.jpg", Genre="Drama" },
        new Movie { Title="District 9", Rating=7.9, Poster="movie16.jpg", Genre="Sci-Fi" },
        new Movie { Title="Moon", Rating=7.8, Poster="movie17.jpg", Genre="Sci-Fi" },
        new Movie { Title="Annihilation", Rating=6.9, Poster="movie18.jpg", Genre="Sci-Fi" },
        new Movie { Title="Edge of Tomorrow", Rating=7.9, Poster="movie19.jpg", Genre="Action" },
        new Movie { Title="Minority Report", Rating=7.6, Poster="movie20.jpg", Genre="Sci-Fi" },

        new Movie { Title="Alien", Rating=8.5, Poster="movie21.jpg", Genre="Sci-Fi" },
        new Movie { Title="Aliens", Rating=8.4, Poster="movie22.jpg", Genre="Sci-Fi" },
        new Movie { Title="Prometheus", Rating=7.0, Poster="movie23.jpg", Genre="Sci-Fi" },
        new Movie { Title="The Martian", Rating=8.0, Poster="movie24.jpg", Genre="Sci-Fi" },
        new Movie { Title="Elysium", Rating=6.6, Poster="movie25.jpg", Genre="Sci-Fi" },
        new Movie { Title="Oblivion", Rating=7.0, Poster="movie26.jpg", Genre="Sci-Fi" },
        new Movie { Title="Looper", Rating=7.4, Poster="movie27.jpg", Genre="Sci-Fi" },
        new Movie { Title="Sunshine", Rating=7.2, Poster="movie28.jpg", Genre="Sci-Fi" },
        new Movie { Title="Ready Player One", Rating=7.5, Poster="movie29.jpg", Genre="Sci-Fi" },
        new Movie { Title="Tron Legacy", Rating=6.8, Poster="movie30.jpg", Genre="Sci-Fi" }
        };

        BindingContext = this;
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
        await Navigation.PushAsync(new MovieDetailsPage(movie));
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
protected override void OnAppearing()
{
    base.OnAppearing();
}

}
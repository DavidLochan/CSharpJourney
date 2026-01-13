using MauiMovies.Models;
using System.Collections.ObjectModel;

namespace MauiMovies;

public partial class MainPage : ContentPage
{
    public ObservableCollection<Movie> Movies { get; set; }

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

    public MainPage()
    {
        InitializeComponent();

        Movies = new ObservableCollection<Movie>
        {
        new Movie { Title="Inception", Rating=8.8, Poster="movie1.jpg" },
        new Movie { Title="Interstellar", Rating=8.6, Poster="movie2.jpg" },
        new Movie { Title="Dune", Rating=8.2, Poster="movie3.jpg" },
		new Movie { Title="The Dark Knight", Rating=9.0, Poster="movie4.jpg" },
        new Movie { Title="Blade Runner 2049", Rating=8.1, Poster="movie5.jpg" },
        new Movie { Title="Tenet", Rating=7.8, Poster="movie6.jpg" },
        new Movie { Title="Arrival", Rating=7.9, Poster="movie7.jpg" },
        new Movie { Title="The Matrix", Rating=8.7, Poster="movie8.jpg" },
        new Movie { Title="Avatar", Rating=7.8, Poster="movie9.jpg" },
        new Movie { Title="Gravity", Rating=7.7, Poster="movie10.jpg" },

        new Movie { Title="Oppenheimer", Rating=8.9, Poster="movie11.jpg" },
        new Movie { Title="The Prestige", Rating=8.5, Poster="movie12.jpg" },
        new Movie { Title="Ex Machina", Rating=7.7, Poster="movie13.jpg" },
        new Movie { Title="Mad Max Fury Road", Rating=8.1, Poster="movie14.jpg" },
        new Movie { Title="Her", Rating=8.0, Poster="movie15.jpg" },
        new Movie { Title="District 9", Rating=7.9, Poster="movie16.jpg" },
        new Movie { Title="Moon", Rating=7.8, Poster="movie17.jpg" },
        new Movie { Title="Annihilation", Rating=6.9, Poster="movie18.jpg" },
        new Movie { Title="Edge of Tomorrow", Rating=7.9, Poster="movie19.jpg" },
        new Movie { Title="Minority Report", Rating=7.6, Poster="movie20.jpg" },

        new Movie { Title="Alien", Rating=8.5, Poster="movie21.jpg" },
        new Movie { Title="Aliens", Rating=8.4, Poster="movie22.jpg" },
        new Movie { Title="Prometheus", Rating=7.0, Poster="movie23.jpg" },
        new Movie { Title="The Martian", Rating=8.0, Poster="movie24.jpg" },
        new Movie { Title="Elysium", Rating=6.6, Poster="movie25.jpg" },
        new Movie { Title="Oblivion", Rating=7.0, Poster="movie26.jpg" },
        new Movie { Title="Looper", Rating=7.4, Poster="movie27.jpg" },
        new Movie { Title="Sunshine", Rating=7.2, Poster="movie28.jpg" },
        new Movie { Title="Ready Player One", Rating=7.5, Poster="movie29.jpg" },
        new Movie { Title="Tron Legacy", Rating=6.8, Poster="movie30.jpg" }
        };

        BindingContext = this;
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
    private void OnMovieTapped(object sender, EventArgs e)
    {
        if (sender is BindableObject bindable &&
            bindable.BindingContext is Movie movie)
        {
            SelectedMovie = movie;
        }
    }

    // Logic for closing the popup
    private void ClosePopup(object sender, EventArgs e) // Added parameters here!
    {
        SelectedMovie = null;
    }

}
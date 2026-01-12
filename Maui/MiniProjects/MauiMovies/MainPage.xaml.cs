using MauiMovies.Models;
using System.Collections.ObjectModel;

namespace MauiMovies;

public partial class MainPage : ContentPage
{   
	 public ObservableCollection<Movie> Movies { get; set; }

    public MainPage()
    {
        InitializeComponent();
		
		Movies = new ObservableCollection<Movie>
        {
            new Movie { Title="Inception", Rating=8.8, Poster="movie1.jpg" },
            new Movie { Title="Interstellar", Rating=8.6, Poster="movie2.jpg" },
            new Movie { Title="Dune", Rating=8.2, Poster="movie3.jpg" }
        };

        BindingContext = this;
    }
}
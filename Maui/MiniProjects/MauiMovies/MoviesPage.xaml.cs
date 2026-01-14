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
        new Movie { 
        Title="Inception", Rating=8.8, Poster="movie1.jpg", Genre="Sci-Fi", Year=2010, Director="Christopher Nolan",
        Description="A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O." 
    },
    new Movie { 
        Title="Interstellar", Rating=8.6, Poster="movie2.jpg", Genre="Sci-Fi", Year=2014, Director="Christopher Nolan",
        Description="When Earth becomes uninhabitable in the future, a farmer and ex-NASA pilot is tasked to pilot a spacecraft, along with a team of researchers, to find a new planet for humans." 
    },
    new Movie { 
        Title="Dune", Rating=8.2, Poster="movie3.jpg", Genre="Sci-Fi", Year=2021, Director="Denis Villeneuve",
        Description="A noble family becomes embroiled in a war for control over the galaxy's most valuable asset while its heir becomes troubled by visions of a dark future." 
    },
    new Movie { 
        Title="The Dark Knight", Rating=9.0, Poster="movie4.jpg", Genre="Action", Year=2008, Director="Christopher Nolan",
        Description="When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice." 
    },
    new Movie { 
        Title="Blade Runner 2049", Rating=8.1, Poster="movie5.jpg", Genre="Sci-Fi", Year=2017, Director="Denis Villeneuve",
        Description="A young Blade Runner's discovery of a long-buried secret leads him to track down former Blade Runner Rick Deckard, who's been missing for thirty years." 
    },
    new Movie { 
        Title="Tenet", Rating=7.8, Poster="movie6.jpg", Genre="Action", Year=2020, Director="Christopher Nolan",
        Description="Armed with only one word, Tenet, and fighting for the survival of the entire world, a Protagonist journeys through a twilight world of international espionage." 
    },
    new Movie { 
        Title="Arrival", Rating=7.9, Poster="movie7.jpg", Genre="Sci-Fi", Year=2016, Director="Denis Villeneuve",
        Description="A linguist works with the military to communicate with extraterrestrial lifeforms after twelve mysterious spacecraft appear around the world." 
    },
    new Movie { 
        Title="The Matrix", Rating=8.7, Poster="movie8.jpg", Genre="Sci-Fi", Year=1999, Director="Lana & Lilly Wachowski",
        Description="When a beautiful stranger leads computer hacker Neo to a forbidding underworld, he discovers the shocking truth--the life he knows is the elaborate deception of an evil cyber-intelligence." 
    },
    new Movie { 
        Title="Avatar", Rating=7.8, Poster="movie9.jpg", Genre="Sci-Fi", Year=2009, Director="James Cameron",
        Description="A paraplegic Marine dispatched to the moon Pandora on a unique mission becomes torn between following his orders and protecting the world he feels is his home." 
    },
    new Movie { 
        Title="Gravity", Rating=7.7, Poster="movie10.jpg", Genre="Sci-Fi", Year=2013, Director="Alfonso Cuarón",
        Description="Two astronauts work together to survive after an accident leaves them stranded in space." 
    },
    new Movie { 
        Title="Oppenheimer", Rating=8.9, Poster="movie11.jpg", Genre="Drama", Year=2023, Director="Christopher Nolan",
        Description="The story of American scientist J. Robert Oppenheimer and his role in the development of the atomic bomb." 
    },
    new Movie { 
        Title="The Prestige", Rating=8.5, Poster="movie12.jpg", Genre="Drama", Year=2006, Director="Christopher Nolan",
        Description="After a tragic accident, two stage magicians in 1890s London engage in a battle to create the ultimate illusion while sacrificing everything they have to outwit each other." 
    },
    new Movie { 
        Title="Ex Machina", Rating=7.7, Poster="movie13.jpg", Genre="Sci-Fi", Year=2014, Director="Alex Garland",
        Description="A young programmer is selected to participate in a ground-breaking experiment in synthetic intelligence by evaluating the human qualities of a highly advanced humanoid A.I." 
    },
    new Movie { 
        Title="Mad Max Fury Road", Rating=8.1, Poster="movie14.jpg", Genre="Action", Year=2015, Director="George Miller",
        Description="In a post-apocalyptic wasteland, a woman rebels against a tyrannical ruler in search for her homeland with the aid of a group of female prisoners, a psychotic worshiper, and a drifter named Max." 
    },
    new Movie { 
        Title="Her", Rating=8.0, Poster="movie15.jpg", Genre="Drama", Year=2013, Director="Spike Jonze",
        Description="In a near future, a lonely writer develops an unlikely relationship with an operating system designed to meet his every need." 
    },
    new Movie { 
        Title="District 9", Rating=7.9, Poster="movie16.jpg", Genre="Sci-Fi", Year=2009, Director="Neill Blomkamp",
        Description="Violence ensues after an extraterrestrial race forced to live in slum-like conditions on Earth finds a kindred spirit in a government agent exposed to their biotechnology." 
    },
    new Movie { 
        Title="Moon", Rating=7.8, Poster="movie17.jpg", Genre="Sci-Fi", Year=2009, Director="Duncan Jones",
        Description="Astronaut Sam Bell has a quintessentially personal encounter toward the end of his three-year stint on the Moon, where he, working alongside his computer, GERTY, sends back to Earth parcels of a resource that has helped alleviate our planet's power problems." 
    },
    new Movie { 
        Title="Annihilation", Rating=6.9, Poster="movie18.jpg", Genre="Sci-Fi", Year=2018, Director="Alex Garland",
        Description="A biologist signs up for a dangerous, secret expedition into a mysterious environmental anomaly where the laws of nature don't apply." 
    },
    new Movie { 
        Title="Edge of Tomorrow", Rating=7.9, Poster="movie19.jpg", Genre="Action", Year=2014, Director="Doug Liman",
        Description="A soldier fighting aliens gets to relive the same day over and over again, the day restarting every time he dies." 
    },
    new Movie { 
        Title="Minority Report", Rating=7.6, Poster="movie20.jpg", Genre="Sci-Fi", Year=2002, Director="Steven Spielberg",
        Description="In a future where a special police unit is able to arrest murderers before they commit their crimes, an officer from that unit is himself accused of a future murder." 
    },
    new Movie { 
        Title="Alien", Rating=8.5, Poster="movie21.jpg", Genre="Sci-Fi", Year=1979, Director="Ridley Scott",
        Description="The crew of a commercial spacecraft encounter a deadly lifeform after investigating an unknown transmission." 
    },
    new Movie { 
        Title="Aliens", Rating=8.4, Poster="movie22.jpg", Genre="Sci-Fi", Year=1986, Director="James Cameron",
        Description="Decades after surviving the first encounter, Ellen Ripley is sent back to the planet LV-426, this time with a team of Colonial Marines." 
    },
    new Movie { 
        Title="Prometheus", Rating=7.0, Poster="movie23.jpg", Genre="Sci-Fi", Year=2012, Director="Ridley Scott",
        Description="Following clues to the origin of mankind, a team finds a structure on a distant moon, but they soon realize they are not alone." 
    },
    new Movie { 
        Title="The Martian", Rating=8.0, Poster="movie24.jpg", Genre="Sci-Fi", Year=2015, Director="Ridley Scott",
        Description="An astronaut becomes stranded on Mars after his team assume him dead, and must rely on his ingenuity to find a way to signal to Earth that he is alive." 
    },
    new Movie { 
        Title="Elysium", Rating=6.6, Poster="movie25.jpg", Genre="Sci-Fi", Year=2013, Director="Neill Blomkamp",
        Description="In the year 2154, the very wealthy live on a man-made space station while the rest of the population resides on a ruined Earth. One man takes on a mission that could bring equality to the polarized worlds." 
    },
    new Movie { 
        Title="Oblivion", Rating=7.0, Poster="movie26.jpg", Genre="Sci-Fi", Year=2013, Director="Joseph Kosinski",
        Description="A veteran assigned to extract remaining resources from a dying Earth begins to question what he knows about his mission and himself." 
    },
    new Movie { 
        Title="Looper", Rating=7.4, Poster="movie27.jpg", Genre="Sci-Fi", Year=2012, Director="Rian Johnson",
        Description="In 2074, when the mob wants to get rid of someone, the target is sent into the past, where a hired gun awaits - someone like Joe - who one day learns the mob wants to 'close the loop' by sending back Joe's future self for assassination." 
    },
    new Movie { 
        Title="Sunshine", Rating=7.2, Poster="movie28.jpg", Genre="Sci-Fi", Year=2007, Director="Danny Boyle",
        Description="A team of international astronauts are sent on a dangerous mission to reignite the dying Sun with a nuclear fission bomb." 
    },
    new Movie { 
        Title="Ready Player One", Rating=7.5, Poster="movie29.jpg", Genre="Sci-Fi", Year=2018, Director="Steven Spielberg",
        Description="When the creator of a virtual reality world called the OASIS dies, he releases a video in which he challenges all OASIS users to find his Easter Egg, which will give the finder his fortune." 
    },
    new Movie { 
        Title="Tron Legacy", Rating=6.8, Poster="movie30.jpg", Genre="Sci-Fi", Year=2010, Director="Joseph Kosinski",
        Description="The son of a virtual world designer goes looking for his father and ends up inside the digital world that his father designed." 
    }
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
protected override void OnAppearing()
{
    base.OnAppearing();
}

}
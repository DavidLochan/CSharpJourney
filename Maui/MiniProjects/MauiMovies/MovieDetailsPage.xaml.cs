using MauiMovies.Models;
using System.Net.Http.Json;

namespace MauiMovies;

[QueryProperty(nameof(MovieId), "id")]
public partial class MovieDetailsPage : ContentPage
{
    private readonly HttpClient _httpClient;

    private int _movieId;
    public int MovieId
    {
        get => _movieId;
        set
        {
            _movieId = value;
            LoadMovieDetails();
        }
    }

    public MovieDetailsPage()
    {
        InitializeComponent();

        _httpClient = new HttpClient
        {
            BaseAddress = new Uri(AppSecrets.TmdbBaseUrl)
        };
    }

    private async void LoadMovieDetails()
    {
        var url = $"movie/{MovieId}?api_key={AppSecrets.TmdbApiKey}";

        var result = await _httpClient.GetFromJsonAsync<MovieResult>(url);

        if (result == null)
            return;

        BindingContext = new Movie
        {
            Title = result.title,
            Rating = result.vote_average,
            Poster = $"https://image.tmdb.org/t/p/w500{result.poster_path}",
            Description = result.overview,
            Year = int.TryParse(result.release_date?.Split('-')[0], out var y) ? y : 0
        };
    }
}
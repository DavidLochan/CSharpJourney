using MauiMovies.Models;
using System.Net.Http.Json;

namespace MauiMovies.Services;

public class MovieService : IMovieService
{
    private readonly HttpClient _httpClient;

    public MovieService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<Movie>> GetTrendingMoviesAsync()
    {
        try
        {
            var url = $"trending/movie/week?api_key={AppSecrets.TmdbApiKey}";
            
            System.Diagnostics.Debug.WriteLine($"Requesting: {url}");
            
            var response = await _httpClient.GetFromJsonAsync<TrendingMovies>(url);

            if (response?.results == null)
            {
                System.Diagnostics.Debug.WriteLine("No results returned");
                return new List<Movie>();
            }

            System.Diagnostics.Debug.WriteLine($"Got {response.results.Count} movies");

            return response.results.Select(m => new Movie
            {
                Id = m.id,
                Title = m.title,
                Rating = m.vote_average,
                Poster = $"https://image.tmdb.org/t/p/w500{m.poster_path}",
                Genre = "Trending"
            }).ToList();
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine($"Error: {ex.Message}");
            return new List<Movie>();
        }
    }
}
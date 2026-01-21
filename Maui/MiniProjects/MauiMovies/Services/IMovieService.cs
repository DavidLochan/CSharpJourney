using MauiMovies.Models;

namespace MauiMovies.Services;

public interface IMovieService
{
    Task<List<Movie>> GetTrendingMoviesAsync();
}
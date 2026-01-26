using MauiMovies.ViewModels;
using MauiMovies.Models;

namespace MauiMovies.Views;

public partial class MoviesPage : ContentPage
{
    private readonly MoviesViewModel _viewModel;

    public MoviesPage(MoviesViewModel viewModel)
    {
        InitializeComponent();
        _viewModel = viewModel;
        BindingContext = _viewModel;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        if (_viewModel.Movies.Count == 0)
        {
            await _viewModel.LoadMoviesAsync();
        }
    }

    // Event handlers for XAML gestures
    private async void OnPointerEntered(object sender, PointerEventArgs e)
    {
        if (sender is VisualElement element)
        {
            await Task.WhenAll(
                element.ScaleToAsync(1.05, 200, Easing.CubicOut),
                element.FadeToAsync(1.0, 200)
            );
        }
    }

    private async void OnPointerExited(object sender, PointerEventArgs e)
    {
        if (sender is VisualElement element)
        {
            await Task.WhenAll(
                element.ScaleToAsync(1.0, 200, Easing.CubicOut),
                element.FadeToAsync(0.9, 200)
            );
        }
    }

    private void OnMovieTapped(object sender, EventArgs e)
    {
        if (sender is BindableObject bindable && bindable.BindingContext is Movie movie)
        {
            _viewModel.SelectedMovie = movie;  // Show popup
        }
    }

    private void ClosePopup(object sender, EventArgs e)
    {
        _viewModel.SelectedMovie = null;  // Close popup
    }

    private void OnGenreClicked(object sender, EventArgs e)
    {
        if (sender is Button btn)
        {
            _viewModel.SelectedGenre = btn.Text;
        }
    }
}
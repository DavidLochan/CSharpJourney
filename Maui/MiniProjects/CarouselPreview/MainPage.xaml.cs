using CarouselPreview.Models;
using System.Collections.ObjectModel;

namespace CarouselPreview;

public partial class MainPage : ContentPage
{
    public ObservableCollection<Product> Products { get; set; }

    public MainPage()
    {
        InitializeComponent();

        Products = new ObservableCollection<Product>
        {
            new Product
            {
                Title = "iPhone 17Pro Max",
                Description = "Flagship device with premium design",
                Image = "phone1.jpg"
            },
            new Product
            {
                Title = "Nothing Phone (3a) Pro",
                Description = "Mid-range phone with great value",
                Image = "phone2.jpg"
            },
            new Product
            {
                Title = "Oneplus ",
                Description = "Compact phone for daily use",
                Image = "phone3.jpg"
            }
        };

        BindingContext = this;
    }
}
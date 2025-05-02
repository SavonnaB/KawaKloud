using System;
using Microsoft.Maui.Controls;

namespace KawaKloud.Views;

public partial class HomePage : ContentPage
{
    public HomePage()
    {
        //InitializeComponent();
    }

    private async void OnPopularAnimeClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(PopularAnimePage));
    }

    private async void OnKidsAnimeClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(AnimeForKidsPage));
    }

    private async void OnNewlyReleasedClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(NewlyReleasedPage));
    }

    private async void OnFavoritesClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(FavoritesPage));
    }
}



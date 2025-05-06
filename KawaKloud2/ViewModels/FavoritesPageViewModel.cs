using System.Collections.ObjectModel;
using KawaKloud2.Models;
using KawaKloud2.Services;

namespace KawaKloud2.ViewModels;

public class FavoritesPageViewModel
{
    public ApiService _apiService;
    public ObservableCollection<AnimeItem> Favorites { get; } = new();

    public FavoritesPageViewModel(ApiService apiService)
    {
        _apiService = apiService;
        LoadFavorites();
    }

    private async void LoadFavorites()
    {
        var anime = await _apiService.GetFavoritesAsync();
        Favorites.Clear();
        foreach (var item in anime)
            Favorites.Add(item);
    }

    public void RemoveFavorite(AnimeItem item)
    {
        if (Favorites.Contains(item))
            Favorites.Remove(item);
    }
}


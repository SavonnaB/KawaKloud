using System.Collections.ObjectModel;
using KawaKloud.Models;
using KawaKloud.Services;

namespace KawaKloud.ViewModels;

public class FavoritesPageViewModel
{
    private readonly ApiService _apiService;
    public ObservableCollection<AnimeItem> Favorites { get; } = new();

    public FavoritesPageViewModel(ApiService apiService)
    {
        _apiService = apiService;
        LoadFavorites();
    }

    private async void LoadFavorites()
    {
        var anime = await _apiService.GetFavoritesAsync(); // or use local storage
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


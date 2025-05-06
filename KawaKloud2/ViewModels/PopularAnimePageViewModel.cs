using System.Collections.ObjectModel;
using KawaKloud2.Models;
using KawaKloud2.Services;

namespace KawaKloud2.ViewModels;

public class PopularAnimePageViewModel
{
    private readonly ApiService _apiService;

    public ObservableCollection<AnimeItem> AnimeList { get; } = new();

    public PopularAnimePageViewModel(ApiService apiService)
    {
        _apiService = apiService;
        LoadPopularAnime();
    }

    private async void LoadPopularAnime()
    {
        var anime = await _apiService.GetPopularAnimeAsync();
        AnimeList.Clear();
        foreach (var item in anime)
            AnimeList.Add(item);
    }
}

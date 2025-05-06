using System.Collections.ObjectModel;
using KawaKloud2.Models;
using KawaKloud2.Services;

namespace KawaKloud2.ViewModels;

public class AnimeForKidsPageViewModel
{
    private readonly ApiService _apiService;
    public ObservableCollection<AnimeItem> KidsAnimeList { get; } = new();

    public AnimeForKidsPageViewModel(ApiService apiService)
    {
        _apiService = apiService;
        LoadKidsAnime();
    }

    private async void LoadKidsAnime()
    {
        var anime = await _apiService.GetKidsAnimeAsync();
        KidsAnimeList.Clear();
        foreach (var item in anime)
            KidsAnimeList.Add(item);
    }
}
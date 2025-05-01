using System.Collections.ObjectModel;
using KawaKloud.Models;
using KawaKloud.Services;

namespace KawaKloud.ViewModels;

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



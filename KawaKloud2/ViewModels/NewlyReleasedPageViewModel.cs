using System.Collections.ObjectModel;
using KawaKloud2.Models;
using KawaKloud2.Services;

namespace KawaKloud2.ViewModels;

public class NewlyReleasedPageViewModel
{
    private readonly ApiService _apiService;
    public ObservableCollection<AnimeItem> NewReleases { get; } = new();

    public NewlyReleasedPageViewModel(ApiService apiService)
    {
        _apiService = apiService;
        LoadNewReleases();
    }

    private async void LoadNewReleases()
    {
        var anime = await _apiService.GetNewlyReleasedAnimeAsync();
        NewReleases.Clear();
        foreach (var item in anime)
            NewReleases.Add(item);
    }
}
using System.Collections.ObjectModel;
using System.ComponentModel;
using KawaKloud.Models;

namespace KawaKloud.ViewModels
{
    public class NewlyReleasedPageViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<AnimeItem> NewReleases { get; } = new();

        public NewlyReleasedPageViewModel()
        {
            NewReleases.Add(new AnimeItem { Title = "Demon Slayer Season 4" });
            NewReleases.Add(new AnimeItem { Title = "Solo Leveling Season 2" });
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}

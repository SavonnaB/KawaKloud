using System.Collections.ObjectModel;
using System.ComponentModel;
using KawaKloud.Models;

namespace KawaKloud.ViewModels
{
    public class AnimeForKidsPageViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<AnimeItem> KidsAnimeList { get; } = new();

        public AnimeForKidsPageViewModel()
        {
            KidsAnimeList.Add(new AnimeItem { Title = "Ponyo" });
            KidsAnimeList.Add(new AnimeItem { Title = "Totoro" });
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}

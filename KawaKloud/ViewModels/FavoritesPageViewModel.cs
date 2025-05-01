using System.Collections.ObjectModel;
using System.ComponentModel;
using KawaKloud.Models;

namespace KawaKloud.ViewModels
{
    public class FavoritesPageViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<AnimeItem> Favorites { get; } = new();

        public FavoritesPageViewModel()
        {
            Favorites.Add(new AnimeItem { Title = "Attack on Titan" });
        }

        public void RemoveFavorite(AnimeItem item)
        {
            if (Favorites.Contains(item))
                Favorites.Remove(item);
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}

public class PopularAnimePageViewModel : INotifyPropertyChanged
{
    public ObservableCollection<AnimeItem> AnimeList { get; } = new();

    public PopularAnimePageViewModel()
    {
        AnimeList.Add(new AnimeItem { Title = "Demon Slayer" });
        AnimeList.Add(new AnimeItem { Title = "One Piece" });
    }

    public event PropertyChangedEventHandler PropertyChanged;
}

namespace KawaKloud.ViewModels
{
    public class HomePageViewModel : INotifyPropertyChanged
    {
        public string WelcomeText => "Welcome to your KawaKloud!";
        public event PropertyChangedEventHandler PropertyChanged;
    }
}

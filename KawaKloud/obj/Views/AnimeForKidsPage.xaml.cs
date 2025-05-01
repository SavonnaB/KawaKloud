namespace KawaKloud.Views;

public partial class AnimeForKidsPage : ContentPage
{
    public AnimeForKidsPage()
    {
        InitializeComponent();
        BindingContext = new AnimeForKidsPageViewModel();
    }
}

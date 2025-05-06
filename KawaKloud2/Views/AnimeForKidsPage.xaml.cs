namespace KawaKloud2.Views;

public partial class AnimeForKidsPage : ContentPage
{
    public AnimeForKidsPage()
    {
        InitializeComponent();
        BindingContext = new AnimeForKidsPageViewModel();
    }
}
namespace KawaKloud.Views;

public partial class FavoritesPage : ContentPage
{
    public FavoritesPage()
    {
        InitializeComponent();
        BindingContext = new FavoritesPageViewModel();
    }
}

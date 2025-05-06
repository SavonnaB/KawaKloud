namespace KawaKloud2.Views;

public partial class FavoritesPage : ContentPage
{
    public FavoritesPage(FavoritesPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel();
    }
}
namespace KawaKloud2.Views;

public partial class PopularAnimePage : ContentPage
{
    public PopularAnimePage(PopularAnimePageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
namespace KawaKloud.Views;

public partial class PopularAnimePage : ContentPage
{
    public PopularAnimePage(PopularAnimePageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}


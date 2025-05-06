using KawaKloud2.ViewModels

namespace KawaKloud2.Views;

public partial class AnimeForKidsPage : ContentPage
{
    public AnimeForKidsPage(AnimeForKidsPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel();
    }
}
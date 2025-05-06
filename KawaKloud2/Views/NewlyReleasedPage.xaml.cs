using KawaKloud2.ViewModels;

namespace KawaKloud2.Views;

public partial class NewlyReleasedPage : ContentPage
{
    public NewlyReleasedPage(NewlyReleasedPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel();
    }
}
namespace KawaKloud2.Views;

public partial class NewlyReleasedPage : ContentPage
{
    public NewlyReleasedPage()
    {
        InitializeComponent();
        BindingContext = new NewlyReleasedPageViewModel();
    }
}
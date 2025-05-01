namespace KawaKloud.Views;

public partial class PopularAnimePage : ContentPage
{
    public PopularAnimePage()
    {
        InitializeComponent();
        BindingContext = new PopularAnimePageViewModel();
    }
}

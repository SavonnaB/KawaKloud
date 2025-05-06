namespace KawaKloud2.Views;

public partial class PopularAnimePage : ContentPage
{
    public PopularAnimePage()
    {
        InitializeComponent();
        BindingContext = new PopularAnimePageviewModel ();
    }
}
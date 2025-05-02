namespace KawaKloud;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(PopularAnimePage),typeof(PopularAnimePage));
        Routing.RegisterRoute(nameof(AnimeForKidsPage),typeof(AnimeForKidsPage));
        Routing.RegisterRoute(nameof(NewlyReleasedPage),typeof(NewlyReleasedPage));
    }
}


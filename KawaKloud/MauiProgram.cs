using KawaKloud.ViewModels;
using Microsoft.Extensions.Logging;

namespace KawaKloud;

namespace KawaKloud;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif
        builder.Services.AddSingleton<AnimeForKidsPageViewModel>();
        builder.Services.AddSingleton<NewlyReleasedPageViewModel>();
        builder.Services.AddSingleton<FavoritesPageViewModel>();
		builder.Services.AddSingleton<PopularAnimePageViewModel>();

        return builder.Build(); 
    }
}


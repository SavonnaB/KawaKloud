using KawaKloud.ViewModels;
using KawaKloud.Services; // <-- Add this if you're using ApiService
using Microsoft.Extensions.Logging;

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
            })
            .ConfigureMauiHandlers(handlers =>
            {
#if ANDROID
                Microsoft.Maui.Handlers.ImageHandler.Mapper.AppendToMapping("SplashFix", (handler, view) =>
                {
                    handler.PlatformView.SetClipToOutline(true);
                });
#endif
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif

        // Api services
        builder.Services.AddSingleton<ApiService>();
        builder.Services.AddSingleton<AnimeForKidsPageViewModel>();
        builder.Services.AddSingleton<NewlyReleasedPageViewModel>();
        builder.Services.AddSingleton<FavoritesPageViewModel>();
        builder.Services.AddSingleton<PopularAnimePageViewModel>();

        return builder.Build(); 
    }
}
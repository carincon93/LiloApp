using CommunityToolkit.Maui;
using LiloApp.Services;
using Microsoft.Extensions.Logging;

using Microsoft.AspNetCore.Components;

namespace LiloApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            #if DEBUG
                builder.Logging.AddDebug();
            #endif

            builder.Services.AddMauiBlazorWebView();

            builder.Services.AddBlazorWebViewDeveloperTools();

            builder.Services.AddSingleton<NavigatorService>();

            return builder.Build();
        }
    }
}

using CommunityToolkit.Maui;
using LiloApp.Services;
using Microsoft.Extensions.Logging;
using LiloApp.ViewModels;
using SQLite;

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
                builder.Services.AddBlazorWebViewDeveloperTools();
             #endif

            builder.Services.AddMauiBlazorWebView();

            builder.Services.AddSingleton<NavigatorService>();

			// Register SQLite connection
			string dbPath = Path.Combine(FileSystem.AppDataDirectory, "LiloApp.db3");
			builder.Services.AddSingleton<SQLiteAsyncConnection>(new SQLiteAsyncConnection(dbPath));

			// Register services
			builder.Services.AddSingleton<LocalDatabaseService>();
			builder.Services.AddSingleton<DreamService>();
			builder.Services.AddSingleton<DreamCalendarService>();
			builder.Services.AddSingleton<MuscleGroupService>();
			builder.Services.AddSingleton<PetService>();
			builder.Services.AddSingleton<OwnerService>();
			builder.Services.AddSingleton<ExerciseService>();
			builder.Services.AddSingleton<TrainingSessionService>();
			builder.Services.AddSingleton<PetLifeService>();
            builder.Services.AddSingleton<MainViewModel>();
            builder.Services.AddScoped<BlazorTransitionableRoute.IRouteTransitionInvoker, BlazorTransitionableRoute.DefaultRouteTransitionInvoker>();

            //builder.Services.AddSingleton<HttpClient>();
            //builder.Services.AddSingleton<ApiService>();

            return builder.Build();
        }
    }
}

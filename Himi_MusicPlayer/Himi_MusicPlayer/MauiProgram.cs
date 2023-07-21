using Himi_MusicPlayer.View;
using Himi_MusicPlayer.ViewModel;
using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Raygun4Maui;
using System.Net;
using Himi_MusicPlayer.View.PopUps;


namespace Himi_MusicPlayer;

public static class MauiProgram
{

	public static MauiApp CreateMauiApp()
	{

        var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
            .UseMauiCommunityToolkitMediaElement()
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			})
			.AddRaygun4Maui("bW5BZSbQdKQItjNJZ0AGQ");

			 AppCenter.Start("android=d3471427-9e8c-42b8-88e5-229e95f1d638;" +
							 "uwp={Your UWP App secret here};" +
							 "ios={Your iOS App secret here};" +
						     "macos={Your macOS App secret here};",
							  typeof(Analytics), typeof(Crashes));

        builder.Services.AddSingleton<StartupPage>();
			builder.Services.AddSingleton<StartupPageViewModel>();
		    builder.Services.AddTransient<AllSongsPage>();
			builder.Services.AddTransient<AllSongsPageViewModel>();
			builder.Services.AddTransient<PlaylistsPage>();
			builder.Services.AddTransient<PlaylistsPageViewModel>();
		    builder.Services.AddTransient<PlayedRecentlyPage>();
			builder.Services.AddTransient<PlayedRecentlyPageViewModel>();
			builder.Services.AddTransient<IPopupService, PopupService>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}

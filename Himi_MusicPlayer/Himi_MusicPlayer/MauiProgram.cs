using Himi_MusicPlayer.View;
using Himi_MusicPlayer.ViewModel;
using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
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

			builder.Services.AddSingleton<StartupPage>();
			builder.Services.AddSingleton<StartupPageViewModel>();
		    builder.Services.AddSingleton<AllSongsPage>();
			builder.Services.AddSingleton<AllSongsPageViewModel>();
			builder.Services.AddSingleton<PlaylistsPage>();
			builder.Services.AddSingleton<PlaylistsPageViewModel>();
			builder.Services.AddTransient<SongDetailPopUp>();
			builder.Services.AddTransient<IPopupService, PopupService>();
			builder.Services.AddTransient<SongDetailPopUp>();
			builder.Services.AddTransient<SongDetailViewModel>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}

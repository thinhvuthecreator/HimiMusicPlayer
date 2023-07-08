using Himi_MusicPlayer.View;
using Himi_MusicPlayer.ViewModel;
using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using Raygun4Maui;
using System.Net;



namespace Himi_MusicPlayer;

public static class MauiProgram
{

	public static MauiApp CreateMauiApp()
	{
        ServicePointManager.SecurityProtocol |= (SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12);

        var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			})
			.AddRaygun4Maui("bW5BZSbQdKQItjNJZ0AGQ");

			builder.Services.AddSingleton<StartupPage>();
			builder.Services.AddSingleton<StartupPageViewModel>();
		    builder.Services.AddTransient<AllSongsPage>();
			builder.Services.AddTransient<AllSongsPageViewModel>();
			builder.Services.AddTransient<PlaylistsPage>();
			builder.Services.AddTransient<PlaylistsPageViewModel>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}

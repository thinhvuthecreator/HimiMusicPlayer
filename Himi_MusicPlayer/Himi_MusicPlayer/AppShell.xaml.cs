using Himi_MusicPlayer.View;

namespace Himi_MusicPlayer;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(AllSongsPage), typeof(AllSongsPage));
        Routing.RegisterRoute(nameof(PlaylistsPage), typeof(PlaylistsPage));
        Routing.RegisterRoute(nameof(PlayedRecentlyPage), typeof(PlayedRecentlyPage));
    }
}

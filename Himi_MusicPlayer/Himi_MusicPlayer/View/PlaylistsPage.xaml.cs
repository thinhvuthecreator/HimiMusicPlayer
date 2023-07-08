using Himi_MusicPlayer.ViewModel;

namespace Himi_MusicPlayer.View;

public partial class PlaylistsPage : ContentPage
{
	public PlaylistsPage(PlaylistsPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}
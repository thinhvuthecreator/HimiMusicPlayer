using Himi_MusicPlayer.ViewModel;

namespace Himi_MusicPlayer.View;

public partial class SongPlayingPage : ContentPage
{
	public SongPlayingPage(SongPlayingPageViewModel vm)
	{
		InitializeComponent();
		this.BindingContext = vm;
	}
}
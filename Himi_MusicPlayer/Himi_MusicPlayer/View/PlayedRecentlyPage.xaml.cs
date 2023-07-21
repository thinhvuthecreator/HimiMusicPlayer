using Himi_MusicPlayer.ViewModel;
namespace Himi_MusicPlayer.View;
public partial class PlayedRecentlyPage : ContentPage
{
	public PlayedRecentlyPage(PlayedRecentlyPageViewModel vm)
	{
		InitializeComponent();
		this.BindingContext = vm;
	}
}
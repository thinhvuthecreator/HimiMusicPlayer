using Himi_MusicPlayer.ViewModel;

namespace Himi_MusicPlayer.View;

public partial class StartupPage : ContentPage
{
	public StartupPage(StartupPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}
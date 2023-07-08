
using Himi_MusicPlayer.ViewModel;
using Microsoft.Maui.Controls.PlatformConfiguration;

namespace Himi_MusicPlayer.View;

public partial class AllSongsPage : ContentPage
{
	public AllSongsPage(AllSongsPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;

    }

}
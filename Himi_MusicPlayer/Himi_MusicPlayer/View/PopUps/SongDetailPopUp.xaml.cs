using CommunityToolkit.Maui.Views;
using Himi_MusicPlayer.ViewModel;

namespace Himi_MusicPlayer.View.PopUps;

public partial class SongDetailPopUp : Popup
{
	public SongDetailPopUp(SongDetailViewModel vm)
	{
		InitializeComponent();
		this.BindingContext = vm;
	}
}
using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace Himi_MusicPlayer.ViewModel
{
    public partial class PlayedRecentlyPageViewModel : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<string> playedRecentlyList;
        [ObservableProperty]
        String songChosenPath;
        IPopupService PopupService;
        PlayedRecentlyPageViewModel(IPopupService popupService) 
        {
            playedRecentlyList = SongPlayedRecentlyList.songPlayedRecentlyList;
            PopupService = popupService;
        }

        [RelayCommand]
        void SongClick_SpecifySong(Label l)
        {
            SongChosenPath = "file:///storage/emulated/0/Download/" + l.Text;
            SongPlayedRecentlyList.songPlayedRecentlyList.Add(l.Text);
        }
        [RelayCommand]
        void SongClick_PlaySong(MediaElement e)
        {
            if (e.CurrentState != CommunityToolkit.Maui.Core.Primitives.MediaElementState.Playing)
            {
                e.Play();
            }
            else if (e.CurrentState == CommunityToolkit.Maui.Core.Primitives.MediaElementState.Playing)
            {
                e.Pause();
            }
        }
        [RelayCommand]
        void ThreeDotClick()
        {
            SongDetailViewModel songDetailViewModel = new SongDetailViewModel();
            PopupService.ShowPopup(new Himi_MusicPlayer.View.PopUps.SongDetailPopUp(songDetailViewModel));
        }

    }
}

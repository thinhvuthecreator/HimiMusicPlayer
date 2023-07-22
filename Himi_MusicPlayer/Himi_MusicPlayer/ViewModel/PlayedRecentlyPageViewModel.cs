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
        public PlayedRecentlyPageViewModel(IPopupService popupService) 
        {
            playedRecentlyList = SongPlayedRecentlyList.songPlayedRecentlyList;
            PopupService = popupService;
        }

        [RelayCommand]
        void SongClick_SpecifySongRecently(Label l)
        {
            SongChosenPath = "file:///storage/emulated/0/Download/" + l.Text;
            MusicPlayer.mediaElement.Source = SongChosenPath;
            if (SongPlayedRecentlyList.songPlayedRecentlyList.IsExist(l.Text))
            {
                SongPlayedRecentlyList.songPlayedRecentlyList.Remove(l.Text);
            }
                SongPlayedRecentlyList.songPlayedRecentlyList.Add(l.Text);
          
        }
        [RelayCommand]
        void SongClick_PlaySongRecently(MediaElement e)
        {
            e.Source = MusicPlayer.mediaElement.Source;
            MusicPlayer.isPlayedBy = "PlayedRecentlyPage";
            if (MusicPlayer.isPlayedBy == "PlayedRecentlyPage")
            {
                e.Play();
            }
            else
            {
                e.Pause();
            }
        }

        [RelayCommand]
        void ThreeDotClickRecently()
        {
            SongDetailViewModel songDetailViewModel = new SongDetailViewModel();
            PopupService.ShowPopup(new Himi_MusicPlayer.View.PopUps.SongDetailPopUp(songDetailViewModel));
        }

    }
}

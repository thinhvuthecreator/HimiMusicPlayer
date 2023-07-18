using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Himi_MusicPlayer.ViewModel
{
    public partial class SongDetailViewModel : ObservableObject
    {
        [RelayCommand]
        void CloseIconClick(Popup popup)
        {
            popup.Close();
            
        }
        [RelayCommand]
        void ChangeNameClick()
        {

        }
        [RelayCommand]
        void AddToPlaylistClick()
        {

        }
        [RelayCommand]
        void DeleteSongClick()
        {

        }
        [RelayCommand]
        void SetPhoneSongClick()
        {

        }
        [RelayCommand]
        void SongInformationClick()
        {

        }
    }
}

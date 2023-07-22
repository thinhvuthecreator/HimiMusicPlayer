using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Himi_MusicPlayer.View;
using Microsoft.AppCenter.Crashes;

namespace Himi_MusicPlayer.ViewModel
{
   public partial class StartupPageViewModel : ObservableObject
    {   
        public StartupPageViewModel()
        {

        }


        [RelayCommand]
        async Task AllSongsClick()
        {
            await Shell.Current.GoToAsync(nameof(AllSongsPage));
        }
        [RelayCommand]
        async Task PlaylistClick()
        {
            await Shell.Current.GoToAsync(nameof(PlaylistsPage));
        }
        [RelayCommand]
        async Task PlayedRecentlyClick()
        {
            await Shell.Current.GoToAsync(nameof(PlayedRecentlyPage));
        }
        [RelayCommand]
        void AddedRecentlyClick()
        {

        }


    }
}

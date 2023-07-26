using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Himi_MusicPlayer.ViewModel
{
    public partial class SongPlayingPageViewModel : ObservableObject
    {
        bool isPlaying = true;
        public SongPlayingPageViewModel() 
        { 
        }

        

        [RelayCommand]
        void Play_Pause_Click(ImageButton button)
        {
           
            if (isPlaying == true)
            {
                button.Source = "play.png";
                button.Padding = 15;
                isPlaying = false;
            }
            else
            {
                button.Source = "pause.png";
                isPlaying = true;
            }
        }
    }
}

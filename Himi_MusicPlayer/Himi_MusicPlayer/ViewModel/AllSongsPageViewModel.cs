using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace Himi_MusicPlayer.ViewModel
{
    public partial class AllSongsPageViewModel : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<string> listNhac;
        [ObservableProperty]
        String songChosenPath;
        IPopupService PopupService;
        public AllSongsPageViewModel(IPopupService popupService)
        { 
            listNhac = new ObservableCollection<string>();

            Thread loadListNhacThread = new Thread(  () =>  {    LoadAllSongsList("/storage/emulated/0/Download/");    }   );
            loadListNhacThread.Start();
            PopupService = popupService;
        }
        
        string LoadAllSongsList(string path)
        {
            if (Directory.Exists(path))
            {
                var Folders = Directory.GetDirectories(path, "*");
                var Files = Directory.GetFiles(path, "*");
                foreach (var folder in Folders)
                {
                    var files = Directory.GetFiles(LoadAllSongsList(folder));
                }
                foreach (var file in Files)
                {
                    FileInfo f = new FileInfo(file);
                    if (f.Extension == ".mp3")
                    {
                        ListNhac.Add(f.Name);
                    }
                }
                if (Directory.GetDirectories(path).Length == 0)
                {
                    return path;
                }
                else
                {
                    return path;
                }
            }
            else { return path; }
           
        }

        [RelayCommand]
        void TimKiemClick()
        {

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
            else if(e.CurrentState == CommunityToolkit.Maui.Core.Primitives.MediaElementState.Playing)
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

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace Himi_MusicPlayer.ViewModel
{
    public partial class AllSongsPageViewModel : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<string> listNhac;
        public AllSongsPageViewModel()
        { 
            listNhac = new ObservableCollection<string>();

            Thread loadListNhacThread = new Thread(  () =>  {    LoadAllSongsList("/storage/emulated/0/Download/");    }   );
            loadListNhacThread.Start();
          
        }

        [RelayCommand]
        void TimKiemClick()
        {

        }

        string LoadAllSongsList(string path)
        {
            var Folders = Directory.GetDirectories(path,"*");
            var Files = Directory.GetFiles(path,"*");
            foreach(var folder in Folders) 
            {
                var files = Directory.GetFiles(LoadAllSongsList(folder));
            }
            foreach(var file in Files)
            {
                FileInfo f = new FileInfo(file);
                if(f.Extension == ".mp3")
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

    }
}

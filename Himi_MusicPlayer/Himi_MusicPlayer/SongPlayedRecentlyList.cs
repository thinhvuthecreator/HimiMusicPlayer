using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace Himi_MusicPlayer
{
    public class SongPlayedRecentlyList : ObservableObject
    {
        public static ObservableCollection<string> songPlayedRecentlyList = new ObservableCollection<string>();
        SongPlayedRecentlyList() 
        {

        }

    }
}

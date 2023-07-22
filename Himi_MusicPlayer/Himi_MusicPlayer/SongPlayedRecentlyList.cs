using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace Himi_MusicPlayer
{
    public class SongPlayedRecentlyList : ObservableObject
    {
        public static CustomObservableCollection<string> songPlayedRecentlyList = new CustomObservableCollection<string>();
        SongPlayedRecentlyList() 
        {

        }

    }
}

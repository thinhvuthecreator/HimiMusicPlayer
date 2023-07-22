using System.Collections.Generic;
using System.Collections.ObjectModel;


namespace Himi_MusicPlayer
{
    public class CustomObservableCollection<T> : ObservableCollection<string>
    {
        public CustomObservableCollection() 
        {

        }
        
        public bool IsExist(string s)
        {
            foreach (var item in this) 
            {
                if (item.Equals(s))
                {
                    return true;
                }
            }
            return false;
        }
    }
}

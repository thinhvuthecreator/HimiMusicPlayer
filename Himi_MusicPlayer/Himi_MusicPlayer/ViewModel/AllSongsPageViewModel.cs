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
            loadlist();
          
        }

        [RelayCommand]
        void TimKiemClick()
        {

        }

        void loadlist()
        {
            int a = 0;
            var tempList = new List<string>();
            for(int i = 0; i <300;i++)
            {
                a++;
                tempList.Add(a.ToString());
            }

            ListNhac = new ObservableCollection<string>(tempList);
        }


       /* async Task task1()
        {
            Task t = new Task(
               () =>
               {
                   int a = 0;

                   for (int i = 0; i < 300; i++)
                   {
                       a++;
                       ListNhac.Add(a.ToString()); 
                   }
               }
               );
            t.Start();
            await t;
        }
       */
      
        //void khoitaoListNhac()
        //{
        //    //var files = Directory.GetFiles("/storage/emulated/0/DCIM/Screenshots/", "*");
            
        //    int a = 0;
            
        //    for (int i = 0; i < 300;i++)
        //    {
        //        a++;
        //        ListNhac.Add(a.ToString());
        //    }

        //}

    }
}

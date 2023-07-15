using CommunityToolkit.Maui.Views;
using Himi_MusicPlayer.ViewModel;
namespace Himi_MusicPlayer.View;

public partial class AllSongsPage : ContentPage
{
	public AllSongsPage(AllSongsPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;

    }

  

    //public class ItemModel
    //{
    //    // other field  
    //    public int Status { get; set; }  // Landscape and portrait  
    //}

    //public class MyDataTemplateSelector : DataTemplateSelector
    //{


    //    public DataTemplate LandTemplate { get; set; }

    //    public DataTemplate PortraitTemplate { get; set; }

    //    protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
    //    {
    //        return ((ItemModel)item).Status == 0 ? LandTemplate : PortraitTemplate;
    //    }
    //}

}
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace Himi_MusicPlayer;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
    protected override void OnCreate(Bundle savedInstanceState)
    {
        if (!Android.OS.Environment.IsExternalStorageManager)
        {
            Intent intent = new Intent();
            intent.SetAction(Android.Provider.Settings.ActionManageAppAllFilesAccessPermission);
            Android.Net.Uri uri = Android.Net.Uri.FromParts("package", this.PackageName, null);
            intent.SetData(uri);
            StartActivity(intent);
        }

        AppCenter.Start("d3471427-9e8c-42b8-88e5-229e95f1d638",
                   typeof(Analytics), typeof(Crashes));
        base.OnCreate(savedInstanceState);
    }
}

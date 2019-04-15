using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace NorthPointApp.Droid
{
    [Activity(Label = "NorthPoint Mobile", 
        Theme = "@style/MyTheme.Splash", 
        MainLauncher = true, 
        NoHistory = true)]

    public class AndroidSplashScreenActivity : Activity
    {
        static readonly string TAG = "X:" + typeof(AndroidSplashScreenActivity).Name;

        public override void OnCreate(Bundle savedInstanceState, PersistableBundle persistentState)
        {
            base.OnCreate(savedInstanceState, persistentState);
            Log.Debug(TAG, "SplashActivity.OnCreate");
        }

        // Launches the startup task
        protected override void OnResume()
        {
            base.OnResume();
            Task startupWork = new Task(() => { StartActivity(new Intent(Application.Context, typeof(MainActivity))); });
            startupWork.Start();
        }

    }
}
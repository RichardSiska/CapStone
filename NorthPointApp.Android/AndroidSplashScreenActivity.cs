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
        //static readonly string TAG = "X:" + typeof(AndroidSplashScreenActivity);

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            StartActivity(typeof(MainActivity));
            Finish();
            OverridePendingTransition(0,0);
        }

    }
}
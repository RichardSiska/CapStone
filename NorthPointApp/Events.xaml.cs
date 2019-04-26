using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NorthPointApp
{
    public partial class Events : ContentPage
    {
        public Events()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
            NavigationPage.SetHasBackButton(this, false);
        }
    }
}

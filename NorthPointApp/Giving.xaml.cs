using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NorthPointApp
{
    public partial class Giving : ContentPage
    {
        public Giving()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
            NavigationPage.SetHasBackButton(this, false);
        }
    }
}

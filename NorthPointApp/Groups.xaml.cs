using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NorthPointApp
{
    public partial class Groups : ContentPage
    {
        public Groups()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
            NavigationPage.SetHasBackButton(this, false);
        }
    }
}

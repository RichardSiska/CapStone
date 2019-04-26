using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NorthPointApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            
        }


        private void Button_Clicked_Redirect(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.northpointchurch.tv"));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NorthPointApp

{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailPageMain : MasterDetailPage
    {
        public MasterDetailPageMain()
        {
           

            InitializeComponent();

            Detail = new NavigationPage(new MainPage { });

            IsPresented = false;
        }

        private void Button_Clicked_HomeNav(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new MainPage { });

            IsPresented = false;
        }

        private void Button_Clicked_GroupsNav(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Groups { });

            IsPresented = false;
        }

        private void Button_Clicked_EventsNav(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Events { });

            IsPresented = false;
        }

        private void Button_Clicked_GivingNav(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Giving { });

            IsPresented = false;
        }
    }
}
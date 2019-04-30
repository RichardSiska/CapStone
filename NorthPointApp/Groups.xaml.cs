using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace NorthPointApp
{
    public partial class Groups : ContentPage
    {
        public ObservableCollection<VeggieViewModel> veggies { get; set; }
        public Groups()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
            NavigationPage.SetHasBackButton(this, false);

            veggies = new ObservableCollection<VeggieViewModel>();
            
            this.Title = "ListView Code Sample";
            veggies.Add(new VeggieViewModel { Name = "Tomato", Type = "Fruit" });
            veggies.Add(new VeggieViewModel { Name = "Romaine Lettuce", Type = "Vegetable" });
            veggies.Add(new VeggieViewModel { Name = "Zucchini", Type = "Vegetable" });
            lstView.ItemsSource = veggies;
        }

       

    }
}

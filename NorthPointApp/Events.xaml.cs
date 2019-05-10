using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace NorthPointApp
{
    public partial class Events : ContentPage
    {
        //public ObservableCollection<VeggieViewModel> veggies { get; set; }
        //private  ObservableCollection<GroupObject> group { get; set; }

        //Create instance of datacollections obj
        //private DataCollection dataCollectionObj = new DataCollection();

        //Create necessary lists for processing
        private List<GroupObject> wedNightGroups = new List<GroupObject>();

        public Events()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
            NavigationPage.SetHasBackButton(this, false);

            //veggies = new ObservableCollection<VeggieViewModel>();
            List<GroupObject> testGroup = new List<GroupObject>();

            //Set the groups corresponding to correct list from data obj
            //wedNightGroups = dataCollectionObj.GetWednesdayGroups();


            //Once working the listview will be able to display groups
            //lstView.ItemsSource = wedNightGroups;

            /*
             * 
             * Done delete the below section
             * 
             * 
             */

            //Test to create groups add to list and display in listview

            //this section properly creates groups and adds them to 
            //An accessable list that the listview can use. 

            //To get this to work all we need to do is correct redirect 
            //Error and then lat the list view have the list.
            GroupObject groupOne = new GroupObject();
            GroupObject groupTwo = new GroupObject();
            GroupObject groupThree = new GroupObject();

            groupOne.Name = "Group One";
            groupOne.Id = "1";


            groupTwo.Name = "Group Two";
            groupTwo.Id = "2";

            groupThree.Name = "Group Three";
            groupThree.Id = "3";


            testGroup.Add(groupOne);
            testGroup.Add(groupTwo);
            testGroup.Add(groupThree);

            /*
             * 
             * 
             * 
             */

            //this.Title = "ListView Code Sample";
            //veggies.Add(new VeggieViewModel { Name = "Tomato", Type = "Fruit" });
            //veggies.Add(new VeggieViewModel { Name = "Romaine Lettuce", Type = "Vegetable" });
            //veggies.Add(new VeggieViewModel { Name = "Zucchini", Type = "Vegetable" });
            //lstView.ItemsSource = veggies;

            //Testing to see if we can do an instance and add to icollectable 
            //group.Add(new GroupObject { Name = "Group One", Id = "1" });
            //group.Add(new GroupObject { Name = "Group Two", Id = "2" });
            //group.Add(new GroupObject { Name = "Group Three", Id= "3" });

            //You will set the list that has the corresponding data to listview.
            lstView.ItemsSource = testGroup;
        }
    }
}

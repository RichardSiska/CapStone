using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace NorthPointApp
{
    public partial class Groups : ContentPage
    {
        //public ObservableCollection<VeggieViewModel> veggies { get; set; }
        //private  ObservableCollection<GroupObject> group { get; set; }

        //Create instance of datacollections obj
        //private DataCollection dataCollectionObj = new DataCollection();

        //Create necessary lists for processing
        private List<GroupObject> wedNightGroups = new List<GroupObject>();
        

        public Groups()
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
            GroupObject groupSeven = new GroupObject();
            GroupObject groupFour = new GroupObject();
            GroupObject groupFive = new GroupObject();
            GroupObject groupSix = new GroupObject();
            GroupObject groupEight = new GroupObject();
            GroupObject groupNine = new GroupObject();
            GroupObject groupTen = new GroupObject();
            GroupObject groupEleven = new GroupObject();
            GroupObject groupTwelve = new GroupObject();
            GroupObject groupThirteen = new GroupObject();
            GroupObject groupFourteen = new GroupObject();
            GroupObject groupFifteen = new GroupObject();
            GroupObject groupSixteen = new GroupObject();
            GroupObject groupSeventeen = new GroupObject();
            GroupObject groupEighteen = new GroupObject();
            GroupObject groupNineteen = new GroupObject();
            GroupObject groupTwenty = new GroupObject();
            GroupObject groupTwentyOne = new GroupObject();
            GroupObject groupTwentyTwo = new GroupObject();
            GroupObject groupTwentyThree = new GroupObject();
            GroupObject groupTwentyFour = new GroupObject();
            GroupObject groupTwentyFive = new GroupObject();
            GroupObject groupTwentySix = new GroupObject();
            GroupObject groupTwentySeven = new GroupObject();
            GroupObject groupTwentyEight = new GroupObject();
            GroupObject groupTwentyNine = new GroupObject();
            GroupObject groupThirty = new GroupObject();
            GroupObject groupThirtyOne = new GroupObject();
            GroupObject groupThirtyTwo = new GroupObject();
            GroupObject groupThirtyThree = new GroupObject();

            groupOne.Id = "720774";
            groupOne.Name = "Nixa - Be A Godly Man";
            groupOne.Schedule = "Wednesday's at 7pm";
            groupOne.LocationName = "North Point Church - NIXA campus";
            groupOne.LocationAddress = "Nixa, MO 65714";
            groupOne.Latitude = "37.06";
            groupOne.Longitude = "-93.3";
            groupOne.Url = "https://northpointchurch.churchcenter.com/groups/wednesday-night-classes/nixa-be-a-godly-man";
            groupTwo.Id = "496665";
            groupTwo.Name = "Nixa - FOUNDATIONS";
            groupTwo.Schedule = "Wednesday's at 7pm"; 
            groupTwo.LocationName = "Nixa Campus Groups Room (Suite 15)";
            groupTwo.LocationAddress = "Nixa, MO 65714";
            groupTwo.Latitude = "37.06";
            groupTwo.Longitude = "-93.3";
            groupTwo.Url = "https://northpointchurch.churchcenter.com/groups/wednesday-night-classes/nixa-foundations";
            groupThree.Id = "713286";
            groupThree.Name = "Nixa - New Testament Survey"; 
            groupThree.Schedule = "Wednesday's at 7pm"; 
            groupThree.LocationName = "Old Commons ";
            groupThree.LocationAddress = "Nixa, MO 65714";
            groupThree.Latitude = "37.06";
            groupThree.Longitude = "-93.3";
            groupThree.Url = "https://northpointchurch.churchcenter.com/groups/wednesday-night-classes/nixa-new-testament-survey";
            groupFour.Id = "503758";
            groupFour.Name = "Nixa - North Point Students"; 
            groupFour.Schedule = "Wednesday's at 7pm"; 
            groupFour.LocationName = "North Point Church - NIXA campus";
            groupFour.LocationAddress = "Nixa, MO 65714";
            groupFour.Latitude = "37.06";
            groupFour.Longitude = "-93.3";
            groupFour.Url = "https://northpointchurch.churchcenter.com/groups/wednesday-night-classes/nixa-north-point-students";
            groupFive.Id = "720555";
            groupFive.Name = "Nixa - The Art Of Marriage"; 
            groupFive.Schedule = "Wednesday's 7:00-8:30pm"; 
            groupFive.LocationName = "North Point Church - NIXA campus";
            groupFive.LocationAddress = "Nixa, MO 65714";
            groupFive.Latitude = "37.06";
            groupFive.Longitude = "-93.3";
            groupFive.Url = "https://northpointchurch.churchcenter.com/groups/wednesday-night-classes/nixa-the-art-of-marriage";
            groupSix.Id = "715343";
            groupSix.Name = "Springfield - Dealing With Life's Issues"; 
            groupSix.Schedule = "Wednesday's at 7pm"; 
            groupSix.LocationName = "North Point Church - Springfield  Campus";
            groupSix.LocationAddress = "Springfield, MO 65803";
            groupSix.Latitude = "37.25";
            groupSix.Longitude = "-93.35";
            groupSix.Url = "https://northpointchurch.churchcenter.com/groups/wednesday-night-classes/springfield-dealing-with-life-s-issues";
            groupSeven.Id = "497384";
            groupSeven.Name = "Springfield - FOUNDATIONS"; 
            groupSeven.Schedule = "Wednesday's at 7pm"; 
            groupSeven.LocationName = "North Point Church - Springfield  Campus";
            groupSeven.LocationAddress = "Springfield, MO 65803";
            groupSeven.Latitude = "37.25";
            groupSeven.Longitude = "-93.35";
            groupSeven.Url = "https://northpointchurch.churchcenter.com/groups/wednesday-night-classes/springfield-foundations";
            groupEight.Id = "705734";
            groupEight.Name = "Springfield - Marriage Class"; 
            groupEight.Schedule = "Wednesday's at 7pm"; 
            groupEight.LocationName = "North Point Church - Springfield  Campus";
            groupEight.LocationAddress = "Springfield, MO 65803";
            groupEight.Latitude = "37.25";
            groupEight.Longitude = "-93.35";
            groupEight.Url = "https://northpointchurch.churchcenter.com/groups/wednesday-night-classes/springfield-marriage-class";
            groupNine.Id = "703883";
            groupNine.Name = "Springfield - Parenting Class"; 
            groupNine.Schedule = "Wednesday's at 7pm"; 
            groupNine.LocationName = "North Point Church - Springfield  Campus";
            groupNine.LocationAddress = "Springfield, MO 65803";
            groupNine.Latitude = "37.25";
            groupNine.Longitude = "-93.35";
            groupNine.Url = "https://northpointchurch.churchcenter.com/groups/wednesday-night-classes/springfield-parenting-class";
            groupTen.Id = "419133";
            groupTen.Name = "Men's Prayer"; 
            groupTen.Schedule = "Tuesdays at 6:30am"; 
            groupTen.LocationName = "North Point Church - Springfield  Campus";
            groupTen.LocationAddress = "Springfield, MO 65803";
            groupTen.Latitude = "37.25";
            groupTen.Longitude = "-93.35";
            groupTen.Url = "https://northpointchurch.churchcenter.com/groups/springfield-groups/men-s-prayer";
            groupEleven.Id = "676184";
            groupEleven.Name = "NEXT - Springfield"; 
            groupEleven.Schedule = "Saturday at 5:00pm, Sunday 11:00am, or Wednesday 7:00pm"; 
            groupEleven.LocationName = "North Point Church - Springfield  Campus";
            groupEleven.LocationAddress = "Springfield, MO 65803";
            groupEleven.Latitude = "37.25";
            groupEleven.Longitude = "-93.35";
            groupEleven.Url = "https://northpointchurch.churchcenter.com/groups/springfield-groups/next-springfield";
            groupTwelve.Id = "416212";
            groupTwelve.Name = "The Book of Signs"; 
            groupTwelve.Schedule = "Tuesdays at 6:15pm starting May 7, 2019"; 
            groupTwelve.LocationName = "North Point Church - SGF";
            groupTwelve.LocationAddress = "Springfield, MO 65803";
            groupTwelve.Latitude = "37.25";
            groupTwelve.Longitude = "-93.35";
            groupTwelve.Url = "https://northpointchurch.churchcenter.com/groups/springfield-groups/the-book-of-signs";
            groupThirteen.Id = "731475";
            groupThirteen.Name = "Volleyball Group"; 
            groupThirteen.Schedule = "Monday's at 7pm"; 
            groupThirteen.LocationName = "Boys & Girls Club";
            groupThirteen.LocationAddress = "Boys & Girls Club";
            groupThirteen.Latitude = "37.22";
            groupThirteen.Longitude = "-93.27";
            groupThirteen.Url = " https://northpointchurch.churchcenter.com/groups/springfield-groups/volleyball-group";
            groupFourteen.Id = "691961";
            groupFourteen.Name = "Young Adult Men's Group"; 
            groupFourteen.Schedule = "Saturday's and Sunday's"; 
            groupFourteen.LocationName = "North Point Church - Springfield  Campus";
            groupFourteen.LocationAddress = "Springfield, MO 65803";
            groupFourteen.Latitude = "37.25";
            groupFourteen.Longitude = "-93.35";
            groupFourteen.Url = " https://northpointchurch.churchcenter.com/groups/springfield-groups/young-adult-men-s-group";
            groupFifteen.Id = "664945";
            groupFifteen.Name = "Young Adult Unmarried Relationship Group"; 
            groupFifteen.Schedule = "Every Other Sunday at 6:00p.m."; 
            groupFifteen.LocationName = "Our Home";
            groupFifteen.LocationAddress = "Springfield, MO 65803";
            groupFifteen.Latitude = "37.34";
            groupFifteen.Longitude = "-93.3";
            groupFifteen.Url = "https://northpointchurch.churchcenter.com/groups/springfield-groups/young-adult-unmarried-relationship-group";
            groupSixteen.Id = "481556";
            groupSixteen.Name = "Wednesday Night Dinner Volunteers"; 
            groupSixteen.Schedule = "Meets every Thursday at 7"; 
            groupSixteen.LocationName = "Springfield Dream Center";
            groupSixteen.LocationAddress = "Springfield Dream Center";
            groupSixteen.Latitude = "37.23";
            groupSixteen.Longitude = "-93.3";
            groupSixteen.Url = "https://northpointchurch.churchcenter.com/groups/dream-center-groups-classes/wednesday-night-dinner-volunteers";
            groupSeventeen.Id = "676196";
            groupSeventeen.Name = "Activity Group for Families of Kids with Special Needs"; 
            groupSeventeen.Schedule = "Wednesday's at 6:00pm"; 
            groupSeventeen.LocationName = "Perspectives Preparatory Academy ";
            groupSeventeen.LocationAddress = "Springfield, MO 65804";
            groupSeventeen.Latitude = "37.14";
            groupSeventeen.Longitude = "-93.27";
            groupSeventeen.Url = "https://northpointchurch.churchcenter.com/groups/nixa-groups/activity-group-for-families-of-kids-with-special-needs";
            groupEighteen.Id = "409470";
            groupEighteen.Name = "Divorce Care"; 
            groupEighteen.Schedule = "Sundays at 6:00pm "; 
            groupEighteen.LocationName = "Nixa Campus Groups Room (Suite 15)";
            groupEighteen.LocationAddress = "Nixa Campus Groups Room (Suite 15)";
            groupEighteen.Latitude = "37.06";
            groupEighteen.Longitude = "-93.3";
            groupEighteen.Url = "https://northpointchurch.churchcenter.com/groups/nixa-groups/divorce-care";
            groupNineteen.Id = "704695";
            groupNineteen.Name = "Fear Not Fitness"; 
            groupNineteen.Schedule = "Sundays at 7 AM "; 
            groupNineteen.LocationName = "Commons Venue at the North Point Nixa Campus";
            groupNineteen.LocationAddress = "Nixa, MO 65714";
            groupNineteen.Latitude = "37.06";
            groupNineteen.Longitude = "-93.3";
            groupNineteen.Url = "https://northpointchurch.churchcenter.com/groups/nixa-groups/fear-not-fitness";
            groupTwenty.Id = "640576";
            groupTwenty.Name = "Financial Peace University - Nixa"; 
            groupTwenty.Schedule = "Sundays 5:00pm"; 
            groupTwenty.LocationName = "North Point Church - NIXA campus";
            groupTwenty.LocationAddress = "Nixa, MO 65714";
            groupTwenty.Latitude = "37.06";
            groupTwenty.Longitude = "-93.3";
            groupTwenty.Url = "https://northpointchurch.churchcenter.com/groups/nixa-groups/financial-peace-university-nixa";
            groupTwentyOne.Id = "720806";
            groupTwentyOne.Name = "Finding Strength Women's Study"; 
            groupTwentyOne.Schedule = "Sunday's at 5pm"; 
            groupTwentyOne.LocationName = "Commons Venue at the North Point Nixa Campus";
            groupTwentyOne.LocationAddress = "Nixa, MO 65714";
            groupTwentyOne.Latitude = "37.06";
            groupTwentyOne.Longitude = "-93.3";
            groupTwentyOne.Url = "https://northpointchurch.churchcenter.com/groups/nixa-groups/finding-strength-women-s-study";
            groupTwentyTwo.Id = "676194";
            groupTwentyTwo.Name = "Intentional Parenting"; 
            groupTwentyTwo.Schedule = "Sunday's at 9:00am"; 
            groupTwentyTwo.LocationName = "Nixa Campus Groups Room (Suite 15";
            groupTwentyTwo.LocationAddress = "Nixa, MO 65714";
            groupTwentyTwo.Latitude = "37.06";
            groupTwentyTwo.Longitude = "-93.3";
            groupTwentyTwo.Url = "https://northpointchurch.churchcenter.com/groups/nixa-groups/intentional-parenting";
            groupTwentyThree.Id = "419333";
            groupTwentyThree.Name = "Men's Breakfast - Nixa"; 
            groupTwentyThree.Schedule = "First Saturday of the month, unless scheduled otherwise."; 
            groupTwentyThree.LocationName = "North Point Church - NIXA campus";
            groupTwentyThree.LocationAddress = "Nixa, MO 65714";
            groupTwentyThree.Latitude = "37.06";
            groupTwentyThree.Longitude = "-93.3";
            groupTwentyThree.Url = "https://northpointchurch.churchcenter.com/groups/nixa-groups/men-s-breakfast-nixa";
            groupTwentyFour.Id = "359405";
            groupTwentyFour.Name = "Men's Morning Coffee and Bible Study"; 
            groupTwentyFour.Schedule = "Tuesdays at 6:30am "; 
            groupTwentyFour.LocationName = "Commons Venue at the North Point Nixa Campus";
            groupTwentyFour.LocationAddress = "Nixa, MO 65714";
            groupTwentyFour.Latitude = "37.06";
            groupTwentyFour.Longitude = "-93.3";
            groupTwentyFour.Url = "https://northpointchurch.churchcenter.com/groups/nixa-groups/men-s-morning-coffee-and-bible-study";
            groupTwentyFive.Id = "676180";
            groupTwentyFive.Name = "NEXT - Nixa"; 
            groupTwentyFive.Schedule = "Wednesday April 10, 7 pm "; 
            groupTwentyFive.LocationName = "Nixa Campus Groups Room (Suite 15)";
            groupTwentyFive.LocationAddress = "Nixa, MO 65714";
            groupTwentyFive.Latitude = "37.06";
            groupTwentyFive.Longitude = " -93.3";
            groupTwentyFive.Url = "https://northpointchurch.churchcenter.com/groups/nixa-groups/next-nixa";
            groupTwentySix.Id = "751285";
            groupTwentySix.Name = "Nixa - Adult Co-Ed Volleyball Group"; 
            groupTwentySix.Schedule = "Fridays at 6pm"; 
            groupTwentySix.LocationName = "Sonic on Battlefield Rd.";
            groupTwentySix.LocationAddress = "Sonic on Battlefield Rd.";
            groupTwentySix.Latitude = "37.16";
            groupTwentySix.Longitude = "-93.29";
            groupTwentySix.Url = "https://northpointchurch.churchcenter.com/groups/nixa-groups/nixa-adult-co-ed-volleyball-group";
            groupTwentySeven.Id = "644910";
            groupTwentySeven.Name = "Nixa - The Exchange"; 
            groupTwentySeven.Schedule = "Wednesday's at 7pm"; 
            groupTwentySeven.LocationName = "North Point Church - NIXA campus";
            groupTwentySeven.LocationAddress = "Nixa, MO 65714";
            groupTwentySeven.Latitude = "37.06";
            groupTwentySeven.Longitude = "-93.3";
            groupTwentySeven.Url = "https://northpointchurch.churchcenter.com/groups/nixa-groups/nixa-the-exchange";
            groupTwentyEight.Id = "676192";
            groupTwentyEight.Name = "None Like Him - Women's Small Group"; 
            groupTwentyEight.Schedule = "Monday's at 6pm"; 
            groupTwentyEight.LocationName = "Commons Venue at the North Point Nixa Campus";
            groupTwentyEight.LocationAddress = "Nixa, MO 65714";
            groupTwentyEight.Latitude = "37.06";
            groupTwentyEight.Longitude = "-93.3";
            groupTwentyEight.Url = "https://northpointchurch.churchcenter.com/groups/nixa-groups/none-like-him-women-s-small-group";
            groupTwentyNine.Id = "419153";
            groupTwentyNine.Name = "Not Quite The NBA"; 
            groupTwentyNine.Schedule = "Tuesdays at 7pm"; 
            groupTwentyNine.LocationName = "Nixa Junior High Gym";
            groupTwentyNine.LocationAddress = "Nixa Junior High Gym";
            groupTwentyNine.Latitude = "37.05";
            groupTwentyNine.Longitude = "-93.29";
            groupTwentyNine.Url = "https://northpointchurch.churchcenter.com/groups/nixa-groups/not-quite-the-nba";
            groupThirty.Id = "409819";
            groupThirty.Name = "Nothing to Prove - Women's Small Group"; 
            groupThirty.Schedule = "Mondays at 9:00am"; 
            groupThirty.LocationName = "Commons Venue at the North Point Nixa Campus";
            groupThirty.LocationAddress = "Nixa, MO 65714";
            groupThirty.Latitude = "37.06";
            groupThirty.Longitude = "-93.3";
            groupThirty.Url = "https://northpointchurch.churchcenter.com/groups/nixa-groups/nothing-to-prove-women-s-small-group";
            groupThirtyOne.Id = "419321";
            groupThirtyOne.Name = "The Breakfast Club"; 
            groupThirtyOne.Schedule = "2nd & 4th Friday's of Month at 9am"; 
            groupThirtyOne.LocationName = "Commons Venue at the North Point Nixa Campus";
            groupThirtyOne.LocationAddress = "Nixa, MO 65714";
            groupThirtyOne.Latitude = "37.06";
            groupThirtyOne.Longitude = "-93.3";
            groupThirtyOne.Url = "";
            groupThirtyTwo.Id = "571307";
            groupThirtyTwo.Name = "Super Serve: Coffee & Cleaning - Springfield"; 
            groupThirtyTwo.Schedule = "Mondays: 10am-12pm"; 
            groupThirtyTwo.LocationName = "North Point Church - Springfield  Campus";
            groupThirtyTwo.LocationAddress = "Springfield, MO 65803";
            groupThirtyTwo.Latitude = "37.25";
            groupThirtyTwo.Longitude = "-93.35";
            groupThirtyTwo.Url = "https://northpointchurch.churchcenter.com/groups/serve-teams/super-serve-coffee-cleaning-springfield";
            groupThirtyThree.Id = "568349";
            groupThirtyThree.Name = "Super Serve: Pizza & Pinning - Springfield"; 
            groupThirtyThree.Schedule = "Wednesdays: 5pm-7pm"; 
            groupThirtyThree.LocationName = "North Point Church - Springfield  Campus";
            groupThirtyThree.LocationAddress = "Springfield, MO 65803";
            groupThirtyThree.Latitude = "37.25";
            groupThirtyThree.Longitude = "-93.35";






            testGroup.Add(groupOne);
            testGroup.Add(groupTwo);
            testGroup.Add(groupThree);
            testGroup.Add(groupFour);
            testGroup.Add(groupFive);
            testGroup.Add(groupSix);
            testGroup.Add(groupSeven);
            testGroup.Add(groupEight);
            testGroup.Add(groupNine);
            testGroup.Add(groupTen);
            testGroup.Add(groupEleven);
            testGroup.Add(groupTwelve);
            testGroup.Add(groupThirteen);
            testGroup.Add(groupFourteen);
            testGroup.Add(groupFifteen);
            testGroup.Add(groupSixteen);
            testGroup.Add(groupSeventeen);
            testGroup.Add(groupEighteen);
            testGroup.Add(groupNineteen);
            testGroup.Add(groupTwenty);
            testGroup.Add(groupTwentyOne);
            testGroup.Add(groupTwentyTwo);
            testGroup.Add(groupTwentyThree);
            testGroup.Add(groupTwentyFour);
            testGroup.Add(groupTwentyFive);
            testGroup.Add(groupTwentySix);
            testGroup.Add(groupTwentySeven);
            testGroup.Add(groupTwentyEight);
            testGroup.Add(groupTwentyNine);
            testGroup.Add(groupThirty);
            testGroup.Add(groupThirtyOne);
            testGroup.Add(groupThirtyTwo);
            testGroup.Add(groupThirtyThree);
     

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


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Http;
using HtmlAgilityPack;
using static System.Console;
using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
//using System.Collections.Generic;


namespace NorthPointApp
{
    /// <summary>
    /// This class is used to extract 
    /// and collect the different data collections
    /// needed for Nothpoint app
    /// </summary>
    class DataCollection
    {

        #region -- Private Fields --
        //Group collections
        private List<GroupObject> WednesdayNightGroupsList = new List<GroupObject>();
        private List<GroupObject> SpringfieldGroupaList = new List<GroupObject>();
        private List<GroupObject> NixaGroupsList = new List<GroupObject>();
        private List<GroupObject> DreamCenterGroupsList = new List<GroupObject>();
        private List<GroupObject> ServeTeamsGroupsList = new List<GroupObject>();

        //Event collections
        private List<EventObject> AllEvents = new List<EventObject>();

        //Stores the count of each group
        private int wedNightNumbers;
        private int springfieldNumbers;
        private int nixaNumbers;
        private int dreamCenterNumbers;
        private int serveTeamNumbers;

        //Number of events
        private int numEvents;



        #endregion

        #region -- Public Properties --

        public int WedNightNumbers { get => wedNightNumbers; set => wedNightNumbers = value; }
        public int SpringfieldNumbers { get => springfieldNumbers; set => springfieldNumbers = value; }
        public int NixaNumbers { get => nixaNumbers; set => nixaNumbers = value; }
        public int DreamCenterNumbers { get => dreamCenterNumbers; set => dreamCenterNumbers = value; }
        public int ServeTeamNumbers { get => serveTeamNumbers; set => serveTeamNumbers = value; }
        public int NumEvents { get => numEvents; set => numEvents = value; }

        #endregion

        #region -- Constructors --
        public DataCollection()
        {

            Console.WriteLine("I am working");
            //Temporary comment out for testing
            WednesdayNnight();
            //SpringfieldGroups();
            //NixaGroups();
            //DreamCenterGroups();
            //ServeTeams();

            //Call for events processing
            //GetEventsHtmlAsync();


        }
        #endregion

        #region -- Methods --
        //We will  make a method like this for each  group
        //static
        private void WednesdayNnight()
        {
            //Define URL to pass pars function
            string url = "https://northpointchurch.churchcenter.com/groups/wednesday-night-classes";

            //Define node this data is located in
            string nodeStr = "//*[@id=\"main_page_content\"]/div/script";

            int caseSwitch = 1;

            //Call function to parse, pass in defined data 
            GetHtmlAsync(url, nodeStr, caseSwitch);



        }

        public void SpringfieldGroups()
        {
            //Define URL to pass pars function
            //I already updated this link
            string url = "https://northpointchurch.churchcenter.com/groups/springfield-groups";

            //Define node this data is located in
            string nodeStr = "//*[@id=\"main_page_content\"]/div/script";

            int caseSwitch = 2;

            //Call function to parse, pass in defined data 
            GetHtmlAsync(url, nodeStr, caseSwitch);


        }

        public void NixaGroups()
        {
            //Define URL to pass pars function
            string url = "https://northpointchurch.churchcenter.com/groups/nixa-groups";

            //Define node this data is located in
            string nodeStr = "//*[@id=\"main_page_content\"]/div/script";

            int caseSwitch = 3;

            //Call function to parse, pass in defined data 
            GetHtmlAsync(url, nodeStr, caseSwitch);


        }

        public void DreamCenterGroups()
        {
            //Define URL to pass pars function
            string url = "https://northpointchurch.churchcenter.com/groups/dream-center-groups-classes";

            //Define node this data is located in
            string nodeStr = "//*[@id=\"main_page_content\"]/div/script";

            int caseSwitch = 4;

            //Call function to parse, pass in defined data 
            GetHtmlAsync(url, nodeStr, caseSwitch);




        }

        public void ServeTeams()
        {
            //Define URL to pass pars function
            string url = "https://northpointchurch.churchcenter.com/groups/serve-teams";

            //Define node this data is located in
            string nodeStr = "//*[@id=\"main_page_content\"]/div/script";

            int caseSwitch = 5;

            //Call function to parse, pass in defined data 
            GetHtmlAsync(url, nodeStr, caseSwitch);




        }

        //private static async 
        private async void GetHtmlAsync(string strUrl, string strNode, int casePassed)
        {
            //class variables
            //Comment out for testing
            //We deleted original url

            //Set to URL being referenced
            var url = strUrl;

            //This is to test our class
            //New instance of search result
            //Commenting out for testing
            //SearchResult DemoObj = new SearchResult();

            try
            {
                var httpClient = new HttpClient();
                //Waits for the document to load


                var html = await httpClient.GetStringAsync(url); //This line is causing redirect





                //Loads the document
                var doc = new HtmlDocument();
                doc.LoadHtml(html);//Commented out for testing



                //Selection node
                //Commented out for testing 
                //HtmlNode node = doc.DocumentNode.SelectSingleNode("//*[@id=\"main_page_content\"]/div/script");
                HtmlNode node = doc.DocumentNode.SelectSingleNode(strNode);


                //Set to generic blank string to be changed as needed in case
                string jSonText = " ";
                string jSonFinal = " ";

                //Create new JSONOBJ for parsing 
                JObject jSon = new JObject();

                //Use a case based on the link being passed in in order to make this part work.
                //Takes node text and converts it into valid JSON
                //Removes first 74 characters

                switch (casePassed)
                {
                    case 1:
                        Console.WriteLine("Case 1 Wed's");

                        //Remove characters before needed JSON
                        jSonText = node.InnerText.Remove(0, 74);

                        //Characters at new (After Remove) to the last 7062 characters
                        jSonFinal = jSonText.Substring(0, 7062);

                        //print moved up here for testing 
                        //WriteLine(jSonFinal);

                        //Parse testing 
                        jSon = JObject.Parse(jSonFinal);

                        break;
                    case 2:
                        Console.WriteLine("Case 2 Springfield");

                        //Remove characters before needed JSON
                        jSonText = node.InnerText.Remove(0, 74);

                        //Characters at new (After Remove) to the last 7062 characters
                        jSonFinal = jSonText.Substring(0, 5797);

                        //print moved up here for testing 
                        //WriteLine(jSonFinal);

                        //Parse testing 
                        jSon = JObject.Parse(jSonFinal + "}}");


                        break;
                    case 3:
                        Console.WriteLine("Case 3 Nixa");


                        //Remove characters before needed JSON
                        jSonText = node.InnerText.Remove(0, 74);

                        //Characters at new (After Remove) to the last 7062 characters
                        jSonFinal = jSonText.Substring(0, 9339);

                        //print moved up here for testing 
                        //WriteLine(jSonFinal);

                        //Parse testing 
                        jSon = JObject.Parse(jSonFinal + "}}");

                        break;
                    case 4:
                        Console.WriteLine("Case 4 Dream");


                        //Remove characters before needed JSON
                        jSonText = node.InnerText.Remove(0, 74);

                        //Characters at new (After Remove) to the last 7062 characters
                        jSonFinal = jSonText.Substring(0, 1523);

                        //print moved up here for testing 
                        //WriteLine(jSonFinal);

                        //Parse testing 
                        jSon = JObject.Parse(jSonFinal);

                        break;
                    case 5:
                        Console.WriteLine("Case 5 Service");


                        //Remove characters before needed JSON
                        jSonText = node.InnerText.Remove(0, 74);

                        //Characters at new (After Remove) to the last 7062 characters
                        jSonFinal = jSonText.Substring(0, 2860);

                        //print moved up here for testing 
                        //WriteLine(jSonFinal);

                        //Parse testing 
                        jSon = JObject.Parse(jSonFinal);

                        break;
                    default:
                        Console.WriteLine("Default case");
                        break;
                }

                //Marked out for testing in case selection
                //string jSonText = node.InnerText.Remove(0, 74);

                //Marked out for testing in wwitch case
                //Characters at new (After Remove) to the last 7062 characters
                //string jSonFinal = jSonText.Substring(0, 7062);

                //Used JSON validator to determin how many characters needed
                //Needed to be removed in order to parse JSON

                //Prints Giant substring -- Good for JSON validation

                //Comment out for testing in case statements
                //WriteLine(jSonFinal);

                //comment out for testing insize case
                //JObject jSon = JObject.Parse(jSonFinal);

                //get JSON result objects into a Enumerablelist
                IList<JToken> results = jSon["groups_index"]["groups"].Children().ToList();

                //Testing variables for foreach
                int count = 0;
                //serialize JSON results into .NET objects
                //IList<SearchResult> searchResults = new List<SearchResult>();
                foreach (JToken result in results)
                {
                    //JToken.ToObject is a helper method that uses JsonSerializer internally
                    //SearchResult searchResult = result.ToObject<SearchResult>();
                    //searchResults.Add(searchResult);
                    //WriteLine(result);
                    //Console.WriteLine("*************");
                    Console.WriteLine($"******** Inside parsing #{count} *********");

                    GroupObject DemoObj = new GroupObject();


                    try
                    {


                        //Cast the result value if JSON object
                        //Assisgn to property of DemoOBJ (Instance of SearchResult)
                        DemoObj.Id = (string)result["id"];
                        DemoObj.Name = (string)result["name"];
                        DemoObj.Schedule = (string)result["schedule"];
                        DemoObj.Enrollment_open = (string)result["enrollment_open"];
                        DemoObj.Enrollment_status = (string)result["enrollment_status"];
                        //To access the internal object use the keypairs like this
                        DemoObj.LocationName = (string)result["location"]["name"];
                        DemoObj.LocationAddress = (string)result["location"]["approximate_address"];
                        DemoObj.Latitude = (string)result["location"]["approximation"]["center"]["lat"];
                        DemoObj.Longitude = (string)result["location"]["approximation"]["center"]["lng"];

                        DemoObj.Header_image_medium = (string)result["header_image_medium"];
                        DemoObj.Url = (string)result["url"];

                    }
                    catch (System.InvalidOperationException e)
                    {
                        //I am able to parse and place the data inside the class without issue,
                        //However I am continuing to recieve the invalidOperation exception for 
                        //trying to access child nodes.
                        Console.WriteLine($"Error Reading child node data Exception: {e}");
                    }

                    //Prints whole JSON OBJ
                    //Console.WriteLine(result);

                    //Writes out data stored into class obj
                    Console.WriteLine("Our demo test iD: " + DemoObj.Id);
                    Console.WriteLine("Our demo test Name: " + DemoObj.Name);
                    Console.WriteLine("Our demo test Schedule:  " + DemoObj.Schedule);
                    Console.WriteLine("Our demo test Enrolment_open:  " + DemoObj.Enrollment_open);
                    Console.WriteLine("Our demo test Enrolment_Status:  " + DemoObj.Enrollment_status);
                    Console.WriteLine("Our demo test LocationName:  " + DemoObj.LocationName);
                    Console.WriteLine("Our demo test LocationAddress:  " + DemoObj.LocationAddress);
                    Console.WriteLine("Our demo test Lat:  " + DemoObj.Latitude);
                    Console.WriteLine("Our demo test Long:  " + DemoObj.Longitude);

                    Console.WriteLine("Our demo test Header_image_medium: " + DemoObj.Header_image_medium);
                    Console.WriteLine("Our demo test url: " + DemoObj.Url);

                    //For itteration, possibly may be useful in class
                    count++;

                    Console.WriteLine($"Addint Demo ID : {DemoObj.Id} ");

                    //Switch case to select which group list the object is sorted into
                    switch (casePassed)
                    {

                        case 1:
                            Console.WriteLine("Case 1 Add Wed's group");

                            //Push to grouplist
                            WednesdayNightGroupsList.Add(DemoObj);



                            break;
                        case 2:
                            Console.WriteLine("Case 2 Add springfield group");

                            //Push to grouplist
                            SpringfieldGroupaList.Add(DemoObj);


                            break;
                        case 3:
                            Console.WriteLine("Case 3  Add Nixa group");

                            //Push to grouplist
                            NixaGroupsList.Add(DemoObj);


                            break;
                        case 4:
                            Console.WriteLine("Case 4 Add Dream group");

                            //Push to grouplist
                            DreamCenterGroupsList.Add(DemoObj);

                            break;
                        case 5:
                            Console.WriteLine("Case 5 Add Service group");

                            //Push to grouplist
                            ServeTeamsGroupsList.Add(DemoObj);



                            break;
                        default:
                            Console.WriteLine("Default case");
                            break;




                    }

                    //For now we are testing to see if we can add each group to list
                    //WednesdayNightGroupsList.Add(DemoObj);




                }
            }
            catch (System.Net.WebException e)
            {
                //Will console log rather than break program
                Console.WriteLine($"Error with auto redirectsion: {e}");
            }


    //Call to count groups after async call
    GetGroupCount();

        }//end of method


        public List<GroupObject> GetWednesdayGroups()
        {
            Console.WriteLine("GetGroups WED called");
            return WednesdayNightGroupsList;
        }

        public List<GroupObject> GetSpringfieldGroups()
        {
            Console.WriteLine("GetGroups Springfield called");
            return SpringfieldGroupaList;
        }
        public List<GroupObject> GetNixaGroups()
        {
            Console.WriteLine("GetGroups Nixa called");
            return NixaGroupsList;
        }

        public List<GroupObject> GetDreamCenterGroups()
        {
            Console.WriteLine("GetGroups Dream called");
            return DreamCenterGroupsList;
        }

        public List<GroupObject> GetServiceTeamGroups()
        {
            Console.WriteLine("GetGroups Service Team called");
            return ServeTeamsGroupsList;
        }

        public List<EventObject> GetEvents()
        {
            Console.WriteLine("Get Events called");
            return AllEvents;
        }

        //Sets group counts 
        private void GetGroupCount()
        {
            //Get count for wednesdays
            this.wedNightNumbers = WednesdayNightGroupsList.Count();

            this.springfieldNumbers = SpringfieldGroupaList.Count();

            this.nixaNumbers = NixaGroupsList.Count();

            this.dreamCenterNumbers = DreamCenterGroupsList.Count();

            this.serveTeamNumbers = ServeTeamsGroupsList.Count();

           
        }

        private void  GetEventsCount()
        {

            this.numEvents = AllEvents.Count();

        }

        public async void GetEventsHtmlAsync()
        {
            int count = 0;

            var url = "https://northpointchurch.churchcenter.com/registrations/events";

            var httpClient = new HttpClient();
            var html = await httpClient.GetStringAsync(url);

            var doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);



            //var headers = doc.DocumentNode
            //    .SelectNodes("//*[@id='main_page_content']/div/section").ToList();
            //("//*[@id='main_page_content']/div/section/article[1]/a/div[2]/div").ToList();
            //("//*[@id='main_page_content']/div/section/article[1]/a/div[2]/div/div[1]").ToList();

            //foreach (var i in headers)
            //{
            //    Console.WriteLine(i.InnerText);
            //}


            //var eventTitle = doc.DocumentNode.SelectNodes("//*[@id='main_page_content']/div/section/article/a/div[2]/div/div[1]/h1")
            //    .Where(node => node.GetAttributeValue("class", "")
            //    .Equals("pr-1 fs-3 mb-0 lh-1.25 card-list-item__title")).ToList();

            var eventTitle = doc.DocumentNode.SelectNodes("//*[@id='main_page_content']/div/section/article/a/div[2]/div/div[1]/h1")
                .Where(node => node.GetAttributeValue("class", "")
                .Equals("pr-1 fs-3 mb-0 lh-1.25 card-list-item__title"));
            var eventTime = doc.DocumentNode.SelectNodes("//*[@id='main_page_content']/div/section/article/a/div[2]/div/div[1]/div")
                .Where(node => node.GetAttributeValue("class", "")
                .Equals("fs-5 lh-1.5 pt-4p card-list-item__details")).ToList();
            var eventPrice = doc.DocumentNode.SelectNodes("//*[@id='main_page_content']/div/section/article/a/div[2]/div/div[2]")
                .Where(node => node.GetAttributeValue("class", "")
                .Equals("badge")).ToList();
            //grabs href from a
            var hrefs = doc.DocumentNode.SelectNodes("//*[@id='main_page_content']/div/section/article");
            var eventUrl = hrefs.Descendants("a")
                .Select(node => node.GetAttributeValue("href", ""))
                .ToList();
            //grabs src from img
            var src = doc.DocumentNode.SelectNodes("//*[@id='main_page_content']/div/section/article/a/div");
            var eventImg = src.Descendants("img")
                .Select(node => node.GetAttributeValue("src", ""))
                .ToList();

            //var eventUrl = doc.DocumentNode.SelectNodes("//*[@id='main_page_content']/div/section/article/a")
            //    .Where(node => node.GetAttributeValue("class", "")
            //    .Equals("card-list-item__wrapper-link"));

            //var eventImg = doc.DocumentNode.SelectNodes("//*[@id='main_page_content']/div/section/article/a/div[1]/img/src").ToList();

            //EventObject demoObj = new EventObject();

            //Obj demoObj = new Obj();
            foreach (var i in eventTitle)
            {
                //Create new object for every found event title
                EventObject demoObj = new EventObject();

                //Add data to each instance
                demoObj.EventTitle = i.InnerText;
                demoObj.EventTime = eventTime[count].InnerText;
                demoObj.EventUrl = eventUrl[count];
                demoObj.EventImg = eventImg[count];
                demoObj.EventPrice = eventPrice[count].InnerText.Trim();
                
                
                //Push event to the event list
                AllEvents.Add(demoObj);
                //Console.WriteLine(i.InnerText);
                //Console.WriteLine(demoObj.EventTitle + " this is from the object");
                //Console.WriteLine(demoObj.EventUrl + " this is from the object");
                //Console.WriteLine(demoObj.EventImg + " this is from the object");
                //Console.WriteLine(demoObj.EventTime + " this is from the object");

                count++;
                Console.WriteLine(count);
            }

            ////Console.WriteLine(demoObj.EventTitle + " this is from the object");
            //// Tests eventTime
            //Console.WriteLine(eventTime[0].InnerText);
            ////Console.WriteLine(eventTime[1].InnerText);
            //// Test eventPrice
            //Console.WriteLine(eventPrice[0].InnerText);
            ////Console.WriteLine(eventPrice[1].InnerText);
            //// Test eventUrl
            //Console.WriteLine(eventUrl[0]);
            //Console.WriteLine(eventUrl[1]);
            //// Test eventImg
            //Console.WriteLine(eventImg[0]);
            //Console.WriteLine(eventImg[1]);



            //for (var i = 0; i < headers.Length; i++)
            //{
            //    Console.WriteLine(headers[i].InnerText);
            //}

            //Console.WriteLine("TEST");
            //Console.WriteLine(headers[0].InnerText);

            //Print events
            PrintEvents();

            //Count the events for collections
            GetEventsCount();

        }//End of events method

        private void PrintEvents()
        {

            foreach (EventObject item in AllEvents)
            {
                Console.WriteLine($"Event Title : {item.EventTitle}");
                Console.WriteLine($"Event Time : {item.EventTime}");
                Console.WriteLine($"Event Price : {item.EventPrice}");
                Console.WriteLine($"Event URL : {item.EventUrl}");
                Console.WriteLine($"Event Image : {item.EventImg}");

                //private string eventTitle;
                //private string eventTime;
                //private string eventPrice;
                //private string eventUrl;
                //private string eventImg;
            }


        }
    }


    #endregion

}

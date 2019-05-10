using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthPointApp
{
    class GroupObject
    {

        #region -- Private Fields--
        //private class fields
        private string id;
        private string name;
        private string schedule;
        private string enrollment_open;
        private string enrollment_status;
        //This one is nested and we will need to use result[Key"]["Key"] to access data.
        private string locationName;
        private string locationAddress;
        private string latitude;
        private string longitude;
        //
        private string header_image_medium;
        private string url;

        //Test variable 
        private int testInt;
        #endregion



        //public class properties
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Schedule { get => schedule; set => schedule = value; }
        public string Enrollment_status { get => enrollment_status; set => enrollment_status = value; }
        public string LocationName { get => locationName; set => locationName = value; }
        public string Header_image_medium { get => header_image_medium; set => header_image_medium = value; }
        public string Url { get => url; set => url = value; }
        public int TestInt { get => testInt; set => testInt = value; }
        public string Enrollment_open { get => enrollment_open; set => enrollment_open = value; }
        public string LocationAddress { get => locationAddress; set => locationAddress = value; }
        public string Latitude { get => latitude; set => latitude = value; }
        public string Longitude { get => longitude; set => longitude = value; }


        #region --Constructors --

        /// <summary>
        /// Default Constructor
        /// </summary>
        public GroupObject()
        {

            this.testInt = 250;

        }

      
        #endregion
    }
}

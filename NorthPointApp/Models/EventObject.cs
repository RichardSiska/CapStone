using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthPointApp
{
    class EventObject
    {
        #region -- Private Fields --
        private string eventTitle;
        private string eventTime;
        private string eventPrice;
        private string eventUrl;
        private string eventImg;

        #endregion


        #region -- Public Properties --

        public string EventTitle { get => eventTitle; set => eventTitle = value; }
        public string EventTime { get => eventTime; set => eventTime = value; }
        public string EventPrice { get => eventPrice; set => eventPrice = value; }
        public string EventUrl { get => eventUrl; set => eventUrl = value; }
        public string EventImg { get => eventImg; set => eventImg = value; }

        #endregion

        #region -- Constructors --

        /// <summary>
        /// Default constructor 
        /// </summary>
        public EventObject()
        {

        }

        #endregion 

    }
}

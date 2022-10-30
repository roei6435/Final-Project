using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Club
{
    internal class EventCalandarcs
    {
        private string eventId;
        private string eventName;
        private string date;
        private string fromHour;
        private string toHour;
        private string location;

        public EventCalandarcs(string eventId, string eventName, string date, string fromHour, string toHour, string location)
        {
            this.eventId = eventId;  
            this.eventName = eventName;
            this.date = date;
            this.fromHour = fromHour;
            this.toHour = toHour;
            this.location = location;
        }
        public string EventID
        {
            get { return eventId; }
            set { eventId = value; }
        }
        public string EventName
        {
            get { return eventName; }
            set { eventName = value; }
        }
        public string Date
        {
            get { return date; }
            set { date = value; }
        }
        public string FromHour
        {
            get { return fromHour; }
            set { fromHour = value; }
        }
        public string ToHour
        {
            get { return toHour; }
            set { toHour = value; }
        }
        public string Location
        {
            get { return location; }
            set { location = value; }
        }


    }
}

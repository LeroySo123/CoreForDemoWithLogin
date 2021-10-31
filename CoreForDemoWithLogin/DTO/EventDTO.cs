using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreForDemoWithLogin.DTO
{
    public class EventDTO
    {
        public int EventID { get; set; }

        public string EventTitle { get; set; }

        public string EventDetail { get; set; }

        public string EventstartDay { get; set; }

        public string EventStartMonth { get; set; }

        public string EventEndDay { get; set; }

        public string EventEndMonth { get; set; }

        public string EventStartTime { get; set; }

        public string EventEndTime { get; set; }
    }
}

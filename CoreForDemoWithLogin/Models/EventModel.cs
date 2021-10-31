using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CoreForDemoWithLogin.Models
{
    public class EventModel
    {
        [Key]
        public int EventID { get; set; }

        public string EventTitle { get; set; }

        public string EventDetail { get; set; }

        public DateTime EventStartDate { get; set; }

        public DateTime EventEndDate { get; set; }

        public DateTime CreateDate { get; set; }
    }
}

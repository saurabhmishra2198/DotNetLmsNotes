using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DapperMVCDemo.Models
{
    public class EventModel
    {
        public int EventId { get; set; }
        public string EventName { get; set; }
        public decimal EventPrice { get; set; }
        public DateTime EventDate { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoMute.Web.Models.Dto
{
    public class Carpool
    {
        public int Car_Pool_ID { get; set; }
        public System.TimeSpan Departure_Time { get; set; }
        public System.TimeSpan Expected_Arrival_Time { get; set; }
        public string Origin { get; set; }
        public string Days_Available { get; set; }
        public string Destination { get; set; }
        public int Available_Seats { get; set; }
        public string Notes { get; set; }
        public Nullable<int> User_ID { get; set; }
        public System.DateTime Date_Created { get; set; }
    }
}
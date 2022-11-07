using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoMute.Web.Models.Dto
{
    public class Time
    {
        public Nullable<int> User_ID { get; set; }

        public Nullable<System.TimeSpan> Departure { get; set; }
        public Nullable<System.TimeSpan> Expected_Arrival { get; set; }
    }
}
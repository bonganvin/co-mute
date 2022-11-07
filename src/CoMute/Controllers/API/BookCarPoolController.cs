using CoMute.Web.Models;
using CoMute.Web.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CoMute.Web.Controllers.API
{
    public class BookCarPoolController : ApiController
    {
        CoMuteEntities db = new CoMuteEntities();
        public HttpResponseMessage BookCarPool(PassengerPool passenger)
        {


            var user = new Passenger_Pool
            {
             User_ID = passenger.User_ID,
                Car_Pool_ID = passenger.Car_Pool_ID,
                Date_Joined = DateTime.Now.Date,
                Passenger_Pool_ID=passenger.Passenger_Pool_ID,
                Status_ID = passenger.Status_ID,

            };

            db.Passenger_Pool.Add(user);

            db.SaveChanges();



            return Request.CreateResponse(HttpStatusCode.Created, user);
        }
    }
}

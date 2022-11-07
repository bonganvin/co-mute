using CoMute.Web.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CoMute.Web.Models;
using System.Web.Http;

namespace CoMute.Web.Controllers.API
{
    public class AddCarPoolController : ApiController
    {
        // GET: AddCarPool
        CoMuteEntities db = new CoMuteEntities();


        public HttpResponseMessage AddCarPool(Carpool pool)
        {
            var car_pool = new Car_Pool
            {
                
                Departure_Time = pool.Departure_Time,
                Expected_Arrival_Time = pool.Expected_Arrival_Time,
                Origin = pool.Origin,
                Days_Available = pool.Days_Available,
                Destination = pool.Destination,
                Available_Seats = pool.Available_Seats,
                Notes = pool.Notes,
                User_ID = pool.User_ID,
                Date_Created = DateTime.Now.Date,
                Car_Pool_ID = pool.Car_Pool_ID,
            };
            db.Car_Pool.Add(car_pool);
            db.SaveChanges();

            return Request.CreateResponse(HttpStatusCode.Created, car_pool);
        }
    }
}
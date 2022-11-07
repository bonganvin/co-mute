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
    public class UpdatePassengersController : ApiController
    {
        public IHttpActionResult Put(Carpool carpool)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid data");

            using (var coMute = new CoMuteEntities())
            {
                var existingPool = coMute.Car_Pool.Where(s => s.Car_Pool_ID == carpool.Car_Pool_ID).FirstOrDefault();

                if (existingPool != null)
                {
                    existingPool.Available_Seats = existingPool.Available_Seats - 1;


                    coMute.SaveChanges();
                }
                else
                {
                    return NotFound();
                }
            }
            return Ok();
        }
    }
}

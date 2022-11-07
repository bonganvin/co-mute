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
    public class EditCarPoolController : ApiController
    {
        public IHttpActionResult Put(Carpool carpool)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid data");

            using (var car = new CoMuteEntities())
            {
                var existingCarPool = car.Car_Pool.Where(s => s.Car_Pool_ID == carpool.Car_Pool_ID).FirstOrDefault();

                if (existingCarPool != null)
                {
                    existingCarPool.Available_Seats = existingCarPool.Available_Seats + 1;
                    car.SaveChanges();
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

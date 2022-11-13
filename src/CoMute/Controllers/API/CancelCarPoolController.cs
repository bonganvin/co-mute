﻿using CoMute.Web.Models;
using CoMute.Web.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CoMute.Web.Controllers.API
{
    public class CancelCarPoolController : ApiController
    {
        public IHttpActionResult Put(PassengerPool user)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid data");

            using (var co = new CoMuteEntities())
            {
                var existingUser = co.Passenger_Pool.Where(s => s.Passenger_Pool_ID == user.Passenger_Pool_ID).FirstOrDefault();

                if (existingUser != null)
                {
                    existingUser.Status_ID = 2;

                    co.SaveChanges();
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

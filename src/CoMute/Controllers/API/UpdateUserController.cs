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
    public class UpdateUserController : ApiController
    {
        public IHttpActionResult Put(RegistrationRequest user)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid data");

            using (var coMute = new CoMuteEntities())
            {
                var existingUser = coMute.Users.Where(zz => zz.User_ID == user.User_ID).FirstOrDefault();

                if (existingUser != null)
                {
                    existingUser.User_Name = user.Name;
                    existingUser.User_Surname = user.Surname;
                    existingUser.Email = user.EmailAddress;
                    existingUser.Phone_Number = user.PhoneNumber;

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

using CoMute.Web.Models;
using CoMute.Web.Models.Dto;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UserClass = CoMute.Web.Models.Dto.User;
using User = CoMute.Web.Models.User;

namespace CoMute.Web.Controllers.API
{
    public class UserController : ApiController
    {
        CoMuteEntities db = new CoMuteEntities();

        [Route("user/add")]
        public HttpResponseMessage Post(RegistrationRequest registrationRequest)
        {
            var user = new UserClass()
            {
                Name = registrationRequest.Name,
                Surname = registrationRequest.Surname,
                EmailAddress = registrationRequest.EmailAddress
            };

            return Request.CreateResponse(HttpStatusCode.Created, user);
        }

        [Route("register")]
        [HttpPost]
        public HttpResponseMessage Register(RegistrationRequest registrationRequest)
        {
            var user = new User
            {
                User_Name = registrationRequest.Name,
                User_Surname = registrationRequest.Surname,
                Email = registrationRequest.EmailAddress,
                Password = registrationRequest.Password,
                Phone_Number = registrationRequest.PhoneNumber,



            };
            db.Users.Add(user);
            db.SaveChanges();

            return Request.CreateResponse(HttpStatusCode.Created, user);
        }
    }
}

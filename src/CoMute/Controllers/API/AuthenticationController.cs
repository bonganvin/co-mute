using CoMute.Web.Models;
using CoMute.Web.Models.Dto;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CoMute.Web.Controllers.API
{
    public class AuthenticationController : ApiController
    {
        CoMuteEntities db = new CoMuteEntities();
        /// <summary>
        /// Logs a user into the application.
        /// </summary>
        /// <param name="loginRequest">The user's login details</param>
        /// <returns></returns>
        public HttpResponseMessage Post(LoginRequest loginRequest)
        {
            var user = db.Users.Where(zz => zz.Email == loginRequest.Email && zz.Password == loginRequest.Password).FirstOrDefault();

            if (user == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
            else
            {

                return Request.CreateResponse(HttpStatusCode.OK);
            }

        }
    }
}

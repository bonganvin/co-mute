
namespace CoMute.Web.Models.Dto
{
    public class RegistrationRequest
    {
        public int User_ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
    }
}

using ClientRegistration.Models.Enums;

namespace ClientRegistration.Models
{
    public class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Subscription Subscription { get; set; }
    }
}

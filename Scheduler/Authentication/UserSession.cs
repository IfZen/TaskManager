
namespace Scheduler.Authentication
{
    public class UserSession
    {
        public string UserName { get; set; }
        public string Role { get; set; }

        public string Password { get; set; }
        public bool Enabled { get; set; }
    }

}

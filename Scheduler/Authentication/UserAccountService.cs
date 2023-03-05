namespace Scheduler.Authentication
{
    // Simulate the database
    public class UserAccountService
    {
        public UserAccountService()
        {
            _users = new List<UserAccount>()
            {
                new UserAccount() { UserName = "admin", Password = "adminTaskManager", Role = "Administrator" },
                new UserAccount() { UserName = "user", Password = "user", Role = "User" }
            };
        }
        readonly List<UserAccount> _users;


        public UserAccount? GetByUserName(string userName)
        {
            return _users.FirstOrDefault(ua => ua.UserName == userName);
        }
    }
}

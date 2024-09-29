using Microsoft.AspNetCore.Identity;

namespace MyWay.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public Role UserRole { get; set; }

        public enum Role
        {
            Admin,
            Consumer,
            Executor,
            Guest
        }

    }
}

using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Personal_training_platform_API.Models
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Username { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Role { get; set; }

        public Profile Profile { get; set; }

        public ICollection<UserGoal> UserGoals { get; set; }
        public ICollection<Routine> Routines { get; set; }

        public ICollection<UserActivity> Activities { get; set; }
    }

}

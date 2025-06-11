namespace Personal_training_platform_API.Models
{
    public class Profile
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public int Age { get; set; }
        public float Height { get; set; } // en cm
        public float Weight { get; set; } // en kg
        public string Gender { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }
    }

}

namespace Personal_training_platform_API.Models
{
    public class UserActivity
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public Guid UserId { get; set; }
        public User User { get; set; }

        public Guid ExerciseId { get; set; }
        public Exercise Exercise { get; set; }

        public DateTime PerformedAt { get; set; }

        public int DurationMinutes { get; set; }
        public int Score { get; set; } // Si se hace evaluación

        public string Notes { get; set; }
    }

}

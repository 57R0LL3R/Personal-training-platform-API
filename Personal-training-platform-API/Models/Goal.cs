namespace Personal_training_platform_API.Models
{
    public class Goal
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Name { get; set; }  // "Perder peso", "Ganar masa", "Definir"
        public string Description { get; set; }

        public ICollection<UserGoal> UserGoals { get; set; }
    }

}

namespace Personal_training_platform_API.Models
{
    public class UserGoal
    {
        public Guid UserId { get; set; }
        public User User { get; set; }

        public Guid GoalId { get; set; }
        public Goal Goal { get; set; }
    }

}

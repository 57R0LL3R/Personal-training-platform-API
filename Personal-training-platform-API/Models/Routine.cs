namespace Personal_training_platform_API.Models
{
    public class Routine
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Name { get; set; }
        public string Description { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }

        public ICollection<RoutineExercise> RoutineExercises { get; set; }
    }

}

namespace Personal_training_platform_API.Models
{
    public class ExerciseMuscle
    {
        public Guid ExerciseId { get; set; } = Guid.NewGuid();
        public Exercise Exercise { get; set; }

        public int MuscleId { get; set; }
        public Muscle Muscle { get; set; }
    }

}

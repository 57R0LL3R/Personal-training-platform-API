namespace Personal_training_platform_API.Models
{
    public class Exercise
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Name { get; set; }
        public string Description { get; set; }

        public string Type { get; set; } // "Warmup", "Workout", "Stretching"

        public ICollection<ExerciseMuscle> MusclesWorked { get; set; }
        public ICollection<MultimediaResource> Media { get; set; }

        public ICollection<RoutineExercise> Routines { get; set; }
    }

}

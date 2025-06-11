namespace Personal_training_platform_API.Models
{

    public class Muscle
    {
        public Guid Id { get; set; }= Guid.NewGuid();
        public string Name { get; set; }

        public ICollection<ExerciseMuscle> Exercises { get; set; }
    }


}

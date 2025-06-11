namespace Personal_training_platform_API.Models
{
    public class Evaluation
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Title { get; set; }
        public string Description { get; set; }

        public Guid RoutineId { get; set; } // o ProgramId si lo separas
        public Routine Routine { get; set; }

        public ICollection<Question> Questions { get; set; }
    }


}

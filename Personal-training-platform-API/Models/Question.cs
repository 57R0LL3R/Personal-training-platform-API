namespace Personal_training_platform_API.Models
{
    public class Question
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Text { get; set; }

        public Guid EvaluationId { get; set; }
        public Evaluation Evaluation { get; set; }

        public ICollection<Answer> Answers { get; set; }
    }

}

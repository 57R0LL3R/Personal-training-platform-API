namespace Personal_training_platform_API.Models
{
    public class Answer
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Text { get; set; }

        public bool IsCorrect { get; set; } // opcional por ahora, útil si luego haces validaciones automáticas

        public Guid QuestionId { get; set; }
        public Question Question { get; set; }
    }

}

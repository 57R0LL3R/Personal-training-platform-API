namespace Personal_training_platform_API.Models
{
    public class MultimediaResource
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Type { get; set; } // "Video", "Image", "Text"
        public string Url { get; set; }
        public string Description { get; set; }

        public Guid ExerciseId { get; set; }
        public Exercise Exercise { get; set; }
    }

}

using Microsoft.AspNetCore.Routing;

namespace Personal_training_platform_API.Models
{
    public class RoutineExercise
    {
        public Guid RoutineId { get; set; }
        public Routine Routine { get; set; }

        public Guid ExerciseId { get; set; }
        public Exercise Exercise { get; set; }

        public int Order { get; set; } // Para definir el orden de ejecución
    }

}

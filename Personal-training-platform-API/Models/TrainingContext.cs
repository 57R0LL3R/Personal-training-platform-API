namespace Personal_training_platform_API.Models
{
    using Microsoft.EntityFrameworkCore;

    public class TrainingContext(DbContextOptions<TrainingContext> options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Goal> Goals { get; set; }
        public DbSet<UserGoal> UserGoals { get; set; }
        public DbSet<Routine> Routines { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<RoutineExercise> RoutineExercises { get; set; }
        public DbSet<MultimediaResource> MultimediaResources { get; set; }
        public DbSet<Muscle> Muscles { get; set; }
        public DbSet<ExerciseMuscle> ExerciseMuscles { get; set; }
        public DbSet<UserActivity> UserActivities { get; set; }
        public DbSet<Evaluation> Evaluations { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // UserGoal (Many-to-Many)
            modelBuilder.Entity<UserGoal>()
                .HasKey(ug => new { ug.UserId, ug.GoalId });

            modelBuilder.Entity<UserGoal>()
                .HasOne(ug => ug.User)
                .WithMany(u => u.UserGoals)
                .HasForeignKey(ug => ug.UserId);

            modelBuilder.Entity<UserGoal>()
                .HasOne(ug => ug.Goal)
                .WithMany(g => g.UserGoals)
                .HasForeignKey(ug => ug.GoalId);

            // RoutineExercise (Many-to-Many with order)
            modelBuilder.Entity<RoutineExercise>()
                .HasKey(re => new { re.RoutineId, re.ExerciseId });

            modelBuilder.Entity<RoutineExercise>()
                .HasOne(re => re.Routine)
                .WithMany(r => r.RoutineExercises)
                .HasForeignKey(re => re.RoutineId);

            modelBuilder.Entity<RoutineExercise>()
                .HasOne(re => re.Exercise)
                .WithMany(e => e.Routines)
                .HasForeignKey(re => re.ExerciseId);

            // ExerciseMuscle (Many-to-Many)
            modelBuilder.Entity<ExerciseMuscle>()
                .HasKey(em => new { em.ExerciseId, em.MuscleId });

            modelBuilder.Entity<ExerciseMuscle>()
                .HasOne(em => em.Exercise)
                .WithMany(e => e.MusclesWorked)
                .HasForeignKey(em => em.ExerciseId);

            modelBuilder.Entity<ExerciseMuscle>()
                .HasOne(em => em.Muscle)
                .WithMany(m => m.Exercises)
                .HasForeignKey(em => em.MuscleId);
        }
    }

}

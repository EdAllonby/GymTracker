using System.Data.Entity;

namespace GymTracker.Models
{
    public class GymContext : DbContext
    {
        public GymContext()
        {
            Database.SetInitializer(new GymContextInitializer());
        }

        public DbSet<Workout> Workouts { get; set; }
    }
}
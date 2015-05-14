using System.Data.Entity;

namespace GymTracker.Entity
{
    public class GymContext : DbContext
    {
        public DbSet<Workout> Workouts { get; set; }
    }
}

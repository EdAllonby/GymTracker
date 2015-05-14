using System.Data.Entity;

namespace GymTracker.Models
{
    public class GymContext : DbContext
    {
        public DbSet<Workout> Workouts { get; set; }
    }
}
using System.Data.Entity;

namespace GymTracker.Entity
{
    public class GymContext : DbContext
    {
        public DbSet<Excercise> Excercises { get; set; }
    }
}

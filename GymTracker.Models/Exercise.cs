using System;

namespace GymTracker.Models
{
    public abstract class Exercise : IEntity
    {
        [Obsolete("Only needed for serialization and materialization", true)]
        protected Exercise()
        {
        }

        protected Exercise(Routine name)
        {
            Name = name;
        }

        public virtual Workout Workout { get; private set; }

        public Routine Name { get; private set; }

        public int Id { get; private set; }
    }
}
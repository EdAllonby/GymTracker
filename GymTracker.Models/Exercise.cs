using System;

namespace GymTracker.Models
{
    public abstract class Exercise : IEntity
    {
        [Obsolete("Only needed for serialization and materialization", true)]
        protected Exercise()
        {
        }

        protected Exercise(Routine routine)
        {
            Routine = routine;
        }

        public Routine Routine { get; private set; }
        public int Id { get; private set; }
    }
}
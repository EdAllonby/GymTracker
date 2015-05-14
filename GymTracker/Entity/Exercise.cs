using System;

namespace GymTracker.Entity
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

        public int Id { get; private set; }

        public Routine Routine { get; private set; }
    }
}
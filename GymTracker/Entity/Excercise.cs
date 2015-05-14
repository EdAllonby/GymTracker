using System;

namespace GymTracker.Entity
{
    public abstract class Excercise : IEntity
    {
        [Obsolete("Only needed for serialization and materialization", true)]
        protected Excercise()
        {
        }

        protected Excercise(Routine routine)
        {
            Routine = routine;
        }

        public int Id { get; private set; }

        public Routine Routine { get; private set; }
    }
}
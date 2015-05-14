using System;

namespace GymTracker.Entity
{
    public abstract class Excercise : IEntity
    {
        [Obsolete("Only needed for serialization and materialization", true)]
        protected Excercise() { }

        protected Excercise(string name)
        {
            Name = name;
            Completion = DateTime.Now;
        }

        public int Id { get; private set; }

        public string Name { get; private set; }

        public DateTime Completion { get; private set; }
    }
}
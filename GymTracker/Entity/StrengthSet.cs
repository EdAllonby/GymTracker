using System;

namespace GymTracker.Entity
{
    public sealed class StrengthSet : Excercise
    {
        public int Reps { get; private set; }

        public double Weight { get; private set; }

        [Obsolete("Only needed for serialization and materialization", true)]
        public StrengthSet() { }

        public StrengthSet(string name, int reps, double weight) : base(name)
        {
            Reps = reps;
            Weight = weight;
        }
    }
}
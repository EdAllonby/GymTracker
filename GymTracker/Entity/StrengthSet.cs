using System;

namespace GymTracker.Entity
{
    public sealed class StrengthSet : Exercise
    {
        [Obsolete("Only needed for serialization and materialization", true)]
        public StrengthSet() { }

        public StrengthSet(Routine routine, int reps, double weight) : base(routine)
        {
            Reps = reps;
            Weight = weight;
        }

        public int Reps { get; private set; }
        public double Weight { get; private set; }
    }
}
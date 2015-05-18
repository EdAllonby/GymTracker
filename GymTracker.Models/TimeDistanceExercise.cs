using System;

namespace GymTracker.Models
{
    public sealed class TimeDistanceExercise : Exercise
    {
        [Obsolete("Only needed for serialization and materialization", true)]
        public TimeDistanceExercise()
        {
        }

        public TimeDistanceExercise(Routine name, TimeSpan time, double meters) : base(name)
        {
            Time = time;
            Meters = meters;
        }

        public TimeSpan Time { get; private set; }

        public double Meters { get; private set; }
    }
}
using System;
using System.Collections.Generic;

namespace GymTracker.Models
{
    public class Workout : IEntity
    {
        public Workout()
        {
            Day = DateTime.Now;
            Exercises = new List<Exercise>();
        }

        public DateTime Day { get; private set; }

        public virtual ICollection<Exercise> Exercises { get;  private set; }

        public int Id { get; private set; }

        public void AddExercise(Exercise exercise)
        {
            Exercises.Add(exercise);
        }
    }
}
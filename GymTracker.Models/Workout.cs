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
        public List<Exercise> Exercises { get; }
        public int Id { get; private set; }

        public void AddExercise(Exercise exercise)
        {
            Exercises.Add(exercise);
        }
    }
}
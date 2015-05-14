using System;
using System.Collections.Generic;
using GymTracker.Entity;

namespace GymTracker
{
    public class Workout : IEntity
    {
        public Workout()
        {
            Day = DateTime.Now;
            Exercises = new List<Exercise>();
        }

        public DateTime Day { get; private set; }
        public List<Exercise> Exercises { get; private set; }
        public int Id { get; private set; }

        public void AddExercise(Exercise exercise)
        {
            Exercises.Add(exercise);
        }
    }
}
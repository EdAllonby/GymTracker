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
            Excercises = new List<Excercise>();
        }

        public DateTime Day { get; private set; }
        public List<Excercise> Excercises { get; private set; }
        public int Id { get; private set; }

        public void AddExcercise(Excercise excercise)
        {
            Excercises.Add(excercise);
        }
    }
}
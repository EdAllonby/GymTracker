using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace GymTracker.Models
{
    public class Workout : IEntity
    {
        /// <summary>
        /// Create a new workout with the day set to today.
        /// </summary>
        public Workout()
        {
            Exercises = new List<Exercise>();
        }

        /// <summary>
        /// Set an explicit workout day.
        /// </summary>
        /// <param name="workoutWorkoutDay">The day of the workout.</param>
        public Workout(DateTime workoutWorkoutDay) : this()
        {
            WorkoutDay = workoutWorkoutDay;
        }
        
        public DateTime WorkoutDay { get; private set; } = DateTime.Now;

        [NotMapped]
        public TimeSpan TimeSinceWorkout => DateTime.Now - WorkoutDay;

        public virtual ICollection<Exercise> Exercises { get;  private set; }

        public int Id { get; private set; }

        public void AddExercise(Exercise exercise)
        {
            Exercises.Add(exercise);
        }
    }
}
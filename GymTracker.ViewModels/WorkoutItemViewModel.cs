using System.Collections.Generic;
using System.Linq;
using GymTracker.Models;

namespace GymTracker.ViewModels
{
    public class WorkoutItemViewModel : NotifiableViewModel
    {
        private readonly Workout workout;

        public WorkoutItemViewModel(Workout workout)
        {
            this.workout = workout;
            Exercises = workout.Exercises.ToList();
        }

        public string WorkoutTime => workout.TimeSinceWorkout.ToDaysAgo();

        public IEnumerable<Exercise> Exercises { get; }
    }
}
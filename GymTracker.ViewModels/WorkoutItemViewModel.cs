using System;
using System.Collections.Generic;
using System.Globalization;
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

        public string WorkoutTime
        {
            get
            {
                TimeSpan span = DateTime.Now - workout.Day;
                return string.Format("{0} Days ago...", span.Days.ToString(CultureInfo.InvariantCulture));
            }
        }

        public IEnumerable<Exercise> Exercises { get; }
    }
}
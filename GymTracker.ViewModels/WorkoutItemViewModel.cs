using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using GymTracker.Models;
using GymTracker.ViewModels.Annotations;

namespace GymTracker.ViewModels
{
    public class WorkoutItemViewModel : INotifyPropertyChanged
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

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

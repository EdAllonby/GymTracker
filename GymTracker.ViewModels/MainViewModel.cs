using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using GymTracker.Models;
using GymTracker.ViewModels.Annotations;

namespace GymTracker.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private WorkoutItemViewModel selectedWorkout;

        public MainViewModel()
        {
            using (var context = new GymContext())
            {
                List<Workout> workouts = context.Workouts.ToList();

                Workouts = new ObservableCollection<WorkoutItemViewModel>();
                Exercises = new ObservableCollection<ExerciseItemViewModel>();

                foreach (Workout workout in workouts)
                {
                    Workouts.Add(new WorkoutItemViewModel(workout));
                }
            }
        }

        public static string Title => "Gym Tracker";

        public ObservableCollection<WorkoutItemViewModel> Workouts { get; set; }

        public ObservableCollection<ExerciseItemViewModel> Exercises { get; set; } 

        public WorkoutItemViewModel SelectedWorkout
        {
            get { return selectedWorkout; }
            set
            {
                Exercises.Clear();
                selectedWorkout = value;

                foreach (Exercise exercise in SelectedWorkout.Exercises)
                {
                    Exercises.Add(new ExerciseItemViewModel(exercise));
                }

                OnPropertyChanged();
            }
        }

        public ExerciseItemViewModel SelectedExercise { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
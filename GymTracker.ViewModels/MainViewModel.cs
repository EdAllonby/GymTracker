using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using GymTracker.Models;
using Microsoft.Practices.Prism.Commands;

namespace GymTracker.ViewModels
{
    public class MainViewModel : NotifiableViewModel
    {
        private ExerciseInformationViewModel exerciseInformationViewModel;
        private string searchWorkouts;
        private ExerciseItemViewModel selectedExercise;
        private WorkoutItemViewModel selectedWorkout;

        public MainViewModel()
        {
            CreateWorkoutCommand = new DelegateCommand(CreateWorkout, CanCreateWorkout);

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
                    var strengthSet = exercise as StrengthSet;
                    if (strengthSet != null)
                    {
                        Exercises.Add(new StrengthSetItemViewModel(strengthSet));
                    }

                    var timeDistanceExercise = exercise as TimeDistanceExercise;
                    if (timeDistanceExercise != null)
                    {
                        Exercises.Add(new TimeDistanceItemViewModel(timeDistanceExercise));
                    }
                }

                OnPropertyChanged();
            }
        }

        public string SearchWorkouts
        {
            get { return searchWorkouts; }
            set
            {
                searchWorkouts = value;

                OnPropertyChanged();
            }
        }

        public DelegateCommand CreateWorkoutCommand { get; }

        public ExerciseItemViewModel SelectedExercise
        {
            get { return selectedExercise; }
            set
            {
                if (value != null)
                {
                    selectedExercise = value;

                    ExerciseInformationViewModel = new ExerciseInformationViewModel(SelectedExercise.ExerciseRoutine);

                    OnPropertyChanged();
                }
            }
        }

        public ExerciseInformationViewModel ExerciseInformationViewModel
        {
            get { return exerciseInformationViewModel; }
            set
            {
                exerciseInformationViewModel = value;
                OnPropertyChanged();
            }
        }

        private bool CanCreateWorkout()
        {
            TimeSpan latestWorkout = TimeSpan.MaxValue;

            using (GymContext gymContext = new GymContext())
            {
                foreach (Workout workout in gymContext.Workouts)
                {
                    if (latestWorkout > workout.TimeSinceWorkout)
                    {
                        latestWorkout = workout.TimeSinceWorkout;
                    }
                }
            }

            return latestWorkout.TotalHours > 4.0;
        }

        private void CreateWorkout()
        {
            var workout = new Workout();

            using (GymContext gymContext = new GymContext())
            {
                gymContext.Workouts.Add(workout);
                gymContext.SaveChanges();
            }

            Workouts.Add(new WorkoutItemViewModel(workout));

            CreateWorkoutCommand.RaiseCanExecuteChanged();
        }
    }
}
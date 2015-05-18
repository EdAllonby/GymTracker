using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using GymTracker.Models;

namespace GymTracker.ViewModels
{
    public class MainViewModel : NotifiableViewModel
    {
        private WorkoutItemViewModel selectedWorkout;
        private string searchWorkouts;
        private ExerciseInformationViewModel exerciseInformationViewModel;
        private ExerciseItemViewModel selectedExercise;

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
    }
}
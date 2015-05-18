using GymTracker.Models;

namespace GymTracker.ViewModels
{
    public sealed class TimeDistanceItemViewModel : ExerciseItemViewModel<TimeDistanceExercise>
    {
        public TimeDistanceItemViewModel(TimeDistanceExercise exercise) : base(exercise)
        {
        }

        public string TimeInMinutes => $"{Exercise.Time.Minutes} Minutes";

        public string DistanceInMeters => $"{Exercise.Meters} Meters";
    }
}
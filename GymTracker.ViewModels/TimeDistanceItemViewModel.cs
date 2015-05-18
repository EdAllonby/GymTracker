using GymTracker.Models;

namespace GymTracker.ViewModels
{
    public sealed class TimeDistanceItemViewModel : ExerciseItemViewModel<TimeDistanceExercise>
    {
        public TimeDistanceItemViewModel(TimeDistanceExercise exercise) : base(exercise)
        {
        }

        public string TimeInMinutes
        {
            get { return string.Format("{0} Minutes", Exercise.Time.Minutes); }
        }

        public string DistanceInMeters
        {
            get { return string.Format("{0} Meters", Exercise.Meters); }
        }
    }
}
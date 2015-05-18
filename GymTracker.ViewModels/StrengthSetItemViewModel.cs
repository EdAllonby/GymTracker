using System.Globalization;
using GymTracker.Models;

namespace GymTracker.ViewModels
{
    public class StrengthSetItemViewModel : ExerciseItemViewModel<StrengthSet>
    {
        public StrengthSetItemViewModel(StrengthSet exercise)
            : base(exercise)
        {
        }

        public string Reps
        {
            get { return string.Format("{0} reps", Exercise.Reps.ToString()); }
        }
        
        public string Weight
        {
            get { return string.Format("{0} kg", Exercise.Weight.ToString(CultureInfo.InvariantCulture)); }
        }
    }
}

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

        public string Reps => $"{Exercise.Reps} reps";

        public string Weight => $"{Exercise.Weight.ToString(CultureInfo.InvariantCulture)} kg";
    }
}

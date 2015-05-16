using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using GymTracker.Models;
using GymTracker.ViewModels.Annotations;
using static GymTracker.ViewModels.EnumExtensions;

namespace GymTracker.ViewModels
{
    public class StrengthSetItemViewModel : INotifyPropertyChanged
    {
        private readonly StrengthSet exercise;

        public StrengthSetItemViewModel(StrengthSet exercise)
        {
            this.exercise = exercise;
        }

        public string ExerciseRoutine
        {
            get { return GetEnumDescription(exercise.Routine); }
        }

        public string Reps
        {
            get { return string.Format("{0} reps", exercise.Reps.ToString()); }
        }
        
        public string Weight
        {
            get { return string.Format("{0} kg", exercise.Weight.ToString(CultureInfo.InvariantCulture)); }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

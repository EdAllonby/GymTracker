using System.ComponentModel;
using System.Runtime.CompilerServices;
using GymTracker.Models;
using GymTracker.ViewModels.Annotations;

namespace GymTracker.ViewModels
{
    public class ExerciseItemViewModel : INotifyPropertyChanged
    {
        private readonly Exercise exercise;

        public ExerciseItemViewModel(Exercise exercise)
        {
            this.exercise = exercise;
        }

        public string ExerciseRoutine => exercise.Routine.ToString();

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

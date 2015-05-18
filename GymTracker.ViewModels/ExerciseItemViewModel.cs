using System.ComponentModel;
using System.Runtime.CompilerServices;
using GymTracker.Models;
using GymTracker.ViewModels.Annotations;

namespace GymTracker.ViewModels
{
    public abstract class ExerciseItemViewModel<TExercise> : ExerciseItemViewModel where TExercise : Exercise
    {
        protected readonly TExercise Exercise;

        protected ExerciseItemViewModel(TExercise exercise)
        {
            Exercise = exercise;
        }

        public string Name
        {
            get { return EnumExtensions.GetEnumDescription(Exercise.Name); }
        }
    }

    public abstract class ExerciseItemViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
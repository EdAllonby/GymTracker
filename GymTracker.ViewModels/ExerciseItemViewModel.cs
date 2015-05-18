using System;
using GymTracker.Models;

namespace GymTracker.ViewModels
{
    public abstract class ExerciseItemViewModel<TExercise> : ExerciseItemViewModel where TExercise : Exercise
    {
        protected readonly TExercise Exercise;

        protected ExerciseItemViewModel(TExercise exercise) : base(exercise)
        {
            Exercise = exercise;
        }

        public string Name
        {
            get { return Exercise.Name.GetEnumDescription(); }
        }
    }

    public abstract class ExerciseItemViewModel : NotifiableViewModel
    {
        public Type ExerciseType { get; }

        public Routine ExerciseRoutine { get; }

        protected ExerciseItemViewModel(Exercise exerciseType)
        {
            ExerciseType = exerciseType.GetType();
            ExerciseRoutine = exerciseType.Name;
        }
    }
}
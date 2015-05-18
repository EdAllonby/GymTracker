using System;
using System.Linq;
using GymTracker.Models;

namespace GymTracker.ViewModels
{
    public class ExerciseInformationViewModel : NotifiableViewModel
    {
        public ExerciseInformationViewModel(Routine routine)
        {
            ExerciseName = routine.GetEnumDescription();

            using (GymContext context = new GymContext())
            {
                TimeSpan lastDateTime = TimeSpan.MaxValue;

                foreach (Workout workout in context.Workouts)
                {
                    foreach (Exercise exercise in workout.Exercises.Where(exercise => exercise.Name.Equals(routine)))
                    {
                        if (lastDateTime > workout.TimeSinceWorkout)
                        {
                            lastDateTime = workout.TimeSinceWorkout;
                        }
                    }
                }

                LastPerformed = lastDateTime.ToDaysAgo();
            }
        }

        public string ExerciseName { get; }

        public string LastPerformed { get; }

        public static string ExerciseDetails => "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed velit mauris, imperdiet vel nunc in, convallis tristique elit. " +
                                         "Nullam sed ipsum porta felis rutrum feugiat sit amet pulvinar diam. Nulla augue quam, rutrum eget magna vitae, congue pulvinar dui. " +
                                         "Mauris enim nunc, tristique quis erat at, dictum tristique metus. Morbi et nulla eu tellus bibendum eleifend eu vitae nisi. " +
                                         "Fusce sit amet arcu vel justo tincidunt accumsan non ut dui. Quisque vitae risus malesuada, placerat libero sed, viverra justo.";
    }
}
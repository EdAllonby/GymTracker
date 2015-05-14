using System.Collections.Generic;
using System.Data.Entity;

namespace GymTracker.Models
{
    public class GymContextInitializer : DropCreateDatabaseAlways<GymContext>
    {
        protected override void Seed(GymContext context)
        {
            IList<Workout> defaultWorkouts = new List<Workout>();

            Workout workout1 = new Workout();

            Exercise exercise1 = new StrengthSet(Routine.BenchPress, 12, 50);
            Exercise exercise2 = new StrengthSet(Routine.Rows, 8, 60);
            Exercise exercise3 = new StrengthSet(Routine.Rows, 5, 80);

            workout1.AddExercise(exercise1);
            workout1.AddExercise(exercise2);
            workout1.AddExercise(exercise3);

            defaultWorkouts.Add(workout1);

            Workout workout2 = new Workout();

            Exercise exercise4 = new StrengthSet(Routine.DumbellPress, 5, 64);
            Exercise exercise5 = new StrengthSet(Routine.DumbellPress, 8, 56);

            workout2.AddExercise(exercise4);
            workout2.AddExercise(exercise5);

            defaultWorkouts.Add(workout2);

            foreach (Workout workout in defaultWorkouts)
            {
                context.Workouts.Add(workout);
            }

            base.Seed(context);
        }
    }

}

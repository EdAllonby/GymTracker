using System;
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

            workout1.AddExercise(new StrengthSet(Routine.BenchPress, 12, 50));
            workout1.AddExercise(new StrengthSet(Routine.Rows, 8, 60));
            workout1.AddExercise(new StrengthSet(Routine.Rows, 5, 80));
            workout1.AddExercise(new TimeDistanceExercise(Routine.Running, TimeSpan.FromMinutes(13), 3000));
            workout1.AddExercise(new TimeDistanceExercise(Routine.Rowing, TimeSpan.FromMinutes(7), 2000));

            defaultWorkouts.Add(workout1);

            Workout workout2 = new Workout();

            workout2.AddExercise(new StrengthSet(Routine.DumbellPress, 5, 64));
            workout2.AddExercise(new StrengthSet(Routine.DumbellPress, 8, 56));

            defaultWorkouts.Add(workout2);

            foreach (Workout workout in defaultWorkouts)
            {
                context.Workouts.Add(workout);
            }

            base.Seed(context);
        }
    }

}

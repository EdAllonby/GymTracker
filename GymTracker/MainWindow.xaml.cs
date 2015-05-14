using System;
using System.Collections.Generic;
using System.Linq;
using GymTracker.Entity;

namespace GymTracker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            using (var gymContext = new GymContext())
            {
                Workout workout = new Workout();
                
                Exercise benchPress = new StrengthSet(Routine.BenchPress, 5, 80);
                workout.AddExercise(benchPress);

                gymContext.Workouts.Add(workout);
                gymContext.SaveChanges();

                List<Workout> workouts = gymContext.Workouts.ToList();
            }
        }
    }
}
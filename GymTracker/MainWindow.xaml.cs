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
                Excercise benchPress = new StrengthSet("Bench Press", 5, 80);
                gymContext.Excercises.Add(benchPress);
                gymContext.SaveChanges();

                List<Excercise> excercises = gymContext.Excercises.ToList();

            }
        }
    }
}
using System;
using GymTracker.Models;
using NUnit.Framework;

namespace GymTracker.Tests
{
    [TestFixture]
    public sealed class WorkoutTests
    {
        [Test]
        public void WorkoutHasDayAsDateNow()
        {
            Workout workout = new Workout();

            double diffInSeconds = (DateTime.Now - workout.WorkoutDay).TotalSeconds;

            Assert.LessOrEqual(diffInSeconds, 5);
        }
    }
}
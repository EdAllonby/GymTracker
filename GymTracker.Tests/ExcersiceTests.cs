using System;
using GymTracker.Entity;
using NUnit.Framework;

namespace GymTracker.Tests
{
    [TestFixture]
    public sealed class ExcersiceTests
    {
        [Test]
        public void ExcerciseHasName()
        {
            const string excerciseName = "row";
            Excercise excercise = new StrengthSet(excerciseName, 20, 20);

            Assert.AreEqual(excercise.Name, excercise);
        }

        [Test]
        public void ExcerciseHasCompletionAsDateNow()
        {
            Excercise excercise = new StrengthSet("excercise", 12, 10.0);

            double diffInSeconds = (DateTime.Now - excercise.Completion).TotalSeconds;

            Assert.LessOrEqual(diffInSeconds, 5);
        }
    }
}
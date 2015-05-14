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
            Routine routine = Routine.BenchPress;
            Excercise excercise = new StrengthSet(routine, 2, 20);

            Assert.AreEqual(excercise.Routine, routine);
        }
    }
}
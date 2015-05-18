using GymTracker.Models;
using NUnit.Framework;

namespace GymTracker.Tests
{
    [TestFixture]
    public sealed class ExcersiceTests
    {
        [Test]
        public void ExerciseHasName()
        {
            Routine routine = Routine.BenchPress;
            Exercise exercise = new StrengthSet(routine, 2, 20);

            Assert.AreEqual(exercise.Name, routine);
        }
    }
}
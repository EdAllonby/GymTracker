using GymTracker.Entity;
using NUnit.Framework;

namespace GymTracker.Tests
{
    [TestFixture]
    public class StrengthSetTests
    {
        [Test]
        public void StrengthSetHasWeight()
        {
            const double weight = 50.5;
            StrengthSet strenghtSet = new StrengthSet(Routine.DumbellPress, 12, weight);

            Assert.AreEqual(weight, strenghtSet.Weight);
        }

        [Test]
        public void StrengthSetHasReps()
        {
            const int reps = 12;
            StrengthSet strengthSet = new StrengthSet(Routine.Rows, reps, 10);

            Assert.AreEqual(reps, strengthSet.Reps);
        }
    }
}
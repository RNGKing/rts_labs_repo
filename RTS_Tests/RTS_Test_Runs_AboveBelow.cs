using Microsoft.VisualStudio.TestTools.UnitTesting;
using RTS_Labs_Exercise;
using System.Collections.ObjectModel;

namespace RTS_Tests
{
    [TestClass]
    public class RTS_Test_Runs_AboveBelow
    {
        [TestMethod]
        public void aboveBelow_AsExample()
        {
            var input = new Collection<int>(){ 1, 2, 3, 4, 5, 6 };
            var comparitor = 3;
            var output = CodingExercise.aboveBelow(input, comparitor);
            Assert.AreEqual(output["above"], 3);
            Assert.AreEqual(output["below"], 2);
        }

        [TestMethod]
        public void aboveBelow_AsExampleWithNegative()
        {
            var input = new Collection<int>() { 1, 2, 3, 4, 5, 6 };
            var comparitor = -3;
            var output = CodingExercise.aboveBelow(input, comparitor);
            Assert.AreEqual(output["above"], 6);
            Assert.AreEqual(output["below"], 0);
        }

        [TestMethod]
        [ExpectedException(typeof(AboveBelowException))]
        public void aboveBelow_DifferentInput()
        {
            var input = new Collection<int>();
            var comparitor = -3;
            var output = CodingExercise.aboveBelow(input, comparitor);
        }

        [TestMethod]
        [ExpectedException(typeof(AboveBelowNullException))]
        public void aboveBelow_NullInput()
        
        {
            Collection<int> input = null;
            var comparitor = -3;
            var output = CodingExercise.aboveBelow(input, comparitor);
        }
    }
}

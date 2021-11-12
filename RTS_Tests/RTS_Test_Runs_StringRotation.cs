using Microsoft.VisualStudio.TestTools.UnitTesting;
using RTS_Labs_Exercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS_Tests
{
    [TestClass]
    public class RTS_Test_Runs_StringRotation
    {
        [TestMethod]
        public void stringRotation_AsExample()
        {
            var result = CodingExercise.stringRotation("MyString", 2);
            Assert.AreEqual("ngMyStri", result);
        }

        [TestMethod]
        public void stringRotation_AsExampleWithNegative()
        {
            var result = CodingExercise.stringRotation("MyString", -2);
            Assert.AreEqual("StringMy", result);
        }

        [TestMethod]
        [ExpectedException(typeof(StringRotationEmptyOrNullException))]
        public void stringRotation_WithEmptyString()
        {
            var result = CodingExercise.stringRotation(string.Empty,
                2);
        }

        [TestMethod]
        [ExpectedException(typeof(StringRotationEmptyOrNullException))]
        public void stringRotation_NullString()
        {
            var result = CodingExercise.stringRotation(null,
                2);
        }
    }
}

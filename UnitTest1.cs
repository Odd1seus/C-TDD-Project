using csharpLabOne;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace csharpLabOneTest
{
    [TestClass()]
    public class UnitTest1
    {

        [TestMethod("checks case when coefficients are equal so function does addition of 2 progressions")]
        public void ProgressionAddCoefsIsEqualTest()
        {
            var progression1 = new Progression(1, 3);
            var progression2 = new Progression(3, 3);
            var expected = new Progression(4, 3);

            var result = progression1.ProgressionAdd(progression2);
            Assert.AreEqual(expected, result);

        }

        [TestMethod("checks case when coefficients are not equal so function throws error")]
        public void ProgressionAddCoefsIsNotEqualTest()
        {
            var progression1 = new Progression(1, 3);
            var progression2 = new Progression(3, 4);
            
            Assert.ThrowsException<InvalidOperationException>(() => progression1.ProgressionAdd(progression2));
        }

        [TestMethod("checks case when coefficients are equal so function does subtraction of 2 progressions")]
        public void ProgressionSubtractIsEqualTest()
        {
            var progression1 = new Progression(5, 2);
            var progression2 = new Progression(3, 2);
            var expected = new Progression(2, 2);

            var result = progression1.ProgressionSubtract(progression2);
            Assert.AreEqual(expected, result);
        }

        [TestMethod("checks case when coefficients are not equal so function throws error")]
        public void ProgressionSubtractIsNotEqualTest()
        {
            var progression1 = new Progression(5, 2);
            var progression2 = new Progression(3, 3);

            Assert.ThrowsException<InvalidOperationException>(() => progression1.ProgressionAdd(progression2));
        }

        [TestMethod("tests multiplying progression by numer function")]
        public void ProgressionMultiplyByNumberTest()
        {
            var progression = new Progression(2, 6);
            var multipier = 3;
            var expected = new Progression(6, 6);

            var result = progression.ProgressionMultiplyByNumber(multipier);
            Assert.AreEqual(expected, result);
        }

        [TestMethod("checks if function correctly calculate the sum of first n elements of progression")]
        public void ProgressionSumOfFirstElementsTest()
        {
            var progression = new Progression(1, 2);
            var number = 3;  
            var expectedSum = 7;  

            var result = progression.ProgressionSumOfFirstElements(number);
            Assert.AreEqual(expectedSum, result);  
        }

        [TestMethod("checks if function that gets element by its number from progression works correctly")]
        public void ProgressionGetElementByNoTest()
        {
            var progression = new Progression(2,4);
            var number = 4;
            var expectedElement = 128;

            var result = progression.ProgressionGetElementByNo(number);
            Assert.AreEqual(expectedElement, result);
        }

        [TestMethod()]
        public void EqualsTest()
        {
            var progression1 = new Progression(1, 3);
            var progression2 = new Progression(1, 3);
            Assert.IsTrue(progression1.Equals(progression2));

            var progression3 = new Progression(1, 4);
            Assert.IsFalse(progression1.Equals(progression3));
        }

        [TestMethod()]
        public void GetHashCodeTest()
        {
            var progression1 = new Progression(1, 3);
            var progression2 = new Progression(1, 3);
            Assert.AreEqual(progression1.GetHashCode(), progression2.GetHashCode());
        }

        [TestMethod()]
        public void ToStringTest()
        {
            var progression = new Progression(2, 4);
            var expected = "Progression: starting element = 2 , coefficient = 4";
            Assert.AreEqual(expected, progression.ToString());
        }
    }
}


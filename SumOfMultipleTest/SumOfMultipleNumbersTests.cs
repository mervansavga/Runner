using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumOfMultiple;
namespace SumOfMultipleTest
{
    [TestClass]
    public class SumOfMultipleNumbersTests
    {
        [TestMethod]
        public void TestFindSumOfMultiplesOfTwoIntegersAndValidUpperLimit()
        {
            int actualResult = SumOfMultiplesOfNumbers.FindSumOfMultiplesOfNumbers(1000, 3, 5);
            int expectedResult = 233168;
            Assert.AreEqual(expectedResult, actualResult, 0, "Found sum is incorrect");
        }

        [TestMethod]
        public void TestFindSumOfMultiplesOfTwoIntegersAndNegativeUpperLimit_Fail()
        {
            int actualResult = SumOfMultiplesOfNumbers.FindSumOfMultiplesOfNumbers(-10, 3, 5);
            int expectedResult = -1;
            Assert.AreEqual(expectedResult, actualResult, 0, "Found sum is incorrect");
        }

        [TestMethod]
        public void TestFindSumOfMultiplesOfTwoIntegersAndSmallUpperLimit_Fail()
        {
            int actualResult = SumOfMultiplesOfNumbers.FindSumOfMultiplesOfNumbers(4, 3, 5);
            int expectedResult = -1;
            Assert.AreEqual(expectedResult, actualResult, 0, "Found sum is incorrect");
        }

        [TestMethod]
        public void TestFindSumOfMultiplesOfNegativeIntegersAndValidUpperLimit_Fail()
        {
            int actualResult = SumOfMultiplesOfNumbers.FindSumOfMultiplesOfNumbers(10, -3, 5);
            int expectedResult = -1;
            Assert.AreEqual(expectedResult, actualResult, 0, "Found sum is incorrect");
        }

    }
}

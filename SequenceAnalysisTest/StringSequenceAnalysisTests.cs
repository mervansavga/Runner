using Microsoft.VisualStudio.TestTools.UnitTesting;
using SequenceAnalysis;
namespace SequenceAnalysisTest
{
    [TestClass]
    public class StringSequenceAnalysisTests
    {
        [TestMethod]
        public void TestAnalyzeStringSequenceWithValidInput()
        {
            string actualResult = StringSequenceAnalysis.AnalyzeStringSequence("This IS a STRING");
            string expectedResult = "GIINRSST";
            Assert.AreEqual(expectedResult, actualResult, false, "The string output is incorrect");

        }
        [TestMethod]
        public void TestAnalyzeStringSequenceWithNumericInput()
        {
            string actualResult = StringSequenceAnalysis.AnalyzeStringSequence("This 1IS23 a STRING");
            string expectedResult = "GINRST";
            Assert.AreEqual(expectedResult, actualResult, false, "The string output is incorrect");

        }

        [TestMethod]
        public void TestAnalyzeStringSequenceWithEmptyInput()
        {
            string actualResult = StringSequenceAnalysis.AnalyzeStringSequence("");
            string expectedResult = "";
            Assert.AreEqual(expectedResult, actualResult, false, "The string output is incorrect");
        }

        [TestMethod]
        public void TestAnalyzeStringSequenceWithSpecialCharacters()
        {
            string actualResult = StringSequenceAnalysis.AnalyzeStringSequence(";S TH!S A STR*NG?");
            string expectedResult = "A";
            Assert.AreEqual(expectedResult, actualResult, false, "The string output is incorrect");
        }

    }
}

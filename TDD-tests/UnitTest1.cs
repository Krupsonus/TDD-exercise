using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_Program;

namespace TDD_tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Return_Correct_Max_Value_From_2_Args()
        {
            Parser parser = new Parser();
            int max = parser.max(2, 4);
            Assert.AreEqual(4, max);
        }

        [TestMethod]
        public void Return_Correct_Min_Value_From_2_Args()
        {
            Parser parser = new Parser();
            int min = parser.min(2, 4);
            Assert.AreEqual(2, min);
        }

        [TestMethod]
        public void Return_True_Value_For_Positive_Number()
        {
            Parser parser = new Parser();
            bool isPositive = parser.isPositive(5);
            Assert.AreEqual(true, isPositive);
        }

        [TestMethod]
        public void Return_False_Value_For_Negative_Number()
        {
            Parser parser = new Parser();
            bool isPositive = parser.isPositive(-5);
            Assert.AreEqual(false, isPositive);
        }


    }
}
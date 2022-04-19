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
    }
}
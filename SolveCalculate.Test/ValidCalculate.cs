using SolveCalculate.Lib;
namespace SolveCalculate.Test
{
    [TestClass]
    public class ValidCalculate
    {
        [TestMethod]
        public void TestCalculateSumma()
        {
            Assert.AreEqual(Calculate.CalculateSumma(5,5), 10);
        }
        [TestMethod]
        public void TestCalculateDifference()
        {
            Assert.AreEqual(Calculate.CalculateDifference(5, 5), 0);
        }
        [TestMethod]
        public void TestCalculateMultiplication()
        {
            Assert.AreEqual(Calculate.CalculateMultiplication(5, 5), 25);
        }
        [TestMethod]
        public void TestCalculateQuotient()
        {
            Assert.AreEqual(Calculate.CalculateQuotient(5, 5), 1);
        }
    }
}
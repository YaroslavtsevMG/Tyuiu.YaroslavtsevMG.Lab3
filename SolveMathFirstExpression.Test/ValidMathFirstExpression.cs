using SolveMathFirstExpression.Lib;
namespace SolveMathFirstExpression.Test
{
    [TestClass]
    public class ValidMathFirstExpression
    {
        [TestMethod]
        public void TestCalculateFirstExpression()
        {
            
            Assert.AreEqual(MathFirstExpression.CalculateFirstExpression(5, 6, 9), 62.05104446411133);
        }
    }
}
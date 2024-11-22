using SolveMathSecondExpression.Lib;
namespace SolveMathSecondExpression.Test
{
    [TestClass]
    public class ValidMathSecondExpression
    {
        [TestMethod]
        public void TestCalculateSecondExpression()
        {
            Assert.AreEqual(MathSecondExpression.CalculateSecondExpression(1, 1, 1), 5.047619342803955);
        }
    }
    
}
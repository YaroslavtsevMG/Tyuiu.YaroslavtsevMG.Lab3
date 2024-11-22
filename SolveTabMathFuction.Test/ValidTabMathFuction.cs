using SolveTabMathFuction.Lib;
namespace SolveTabMathFuction.Test
{
    [TestClass]
    public class ValidTabMathFuction
    {
        [TestMethod]
        public void TestCalculateTabMathFunction()
        {
            double[] array = { -2.82,
-13.66,
4.38,
1.17,
0.17,
0.09,
1.82,
-15.48,
-3.16,
-1.44
};
            CollectionAssert.AreEqual(array, TabMathFuction.CalculateTabMathFuction(0,10));
        }
    }
}
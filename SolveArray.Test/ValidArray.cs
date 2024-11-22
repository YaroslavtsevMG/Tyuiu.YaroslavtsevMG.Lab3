using SolveArray.Lib;
namespace SolveArray.Test
{
    [TestClass]
    public class ValidArray
    {
        [TestMethod]
        public void TestCalculateMinimum()
        {
            float[] x = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 10, 11, -1 ,-30,-4040450,2334243,33,3,343};
            Assert.AreEqual(Lib.Array.CalculateMinimum(x), -4040450);
        }
        [TestMethod]
        public void TestCalculateMaximum()
        {
            float[] x = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 10, 11, -1, -30, -4040450, 2334243, 33, 3, 343 };
            Assert.AreEqual(Lib.Array.CalculateMaximum(x), 2334243);
        }
        [TestMethod]
        public void TestCalculateAverage()
        {
            float[] x = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 10, 11, -1, -30, -4040450, 2334243, 33, 3, 343 };
            Assert.AreEqual(Lib.Array.CalculateAverage(x), (float)(1+2+3+4+5+6+7+8+9+0+10+11-1-30-4040450+2334243+33+3+343)/(float)19);
        }
        [TestMethod]
        public void TestCalculateMedian()
        {
            float[] x = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 10, 11, -1, -30, -4040450, 2334243, 33, 3, 343 };
            Assert.AreEqual(Lib.Array.CalculateMedian(x), 5);
        }
        [TestMethod]
        public void TestCalculateNumberOfEven()
        {
            float[] x = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 10, 11, -1, -30, -4040450, 2334243, 33, 3, 343 };
            Assert.AreEqual(Lib.Array.CalculateNumberOfEven(x), 8);
        }
        [TestMethod]
        public void TestCalculateNumberOfOdd()
        {
            float[] x = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 10, 11, -1, -30, -4040450, 2334243, 33, 3, 343 };
            Assert.AreEqual(Lib.Array.CalculateNumberOfOdd(x), 11);
        }
        [TestMethod]
        public void TestSignsOfDivisibilityByTwo()
        {
            float[] x = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 10, 11, -1, -30, -4040450, 2334243, 33, 3, 343 };
            Assert.AreEqual(Lib.Array.SignsOfDivisibilityByTwo(x), 8);
        }
        [TestMethod]
        public void TestSignsOfDivisibilityByThree()
        {
            float[] x = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 10, 11, -1, -30, -4040450, 2334243, 33, 3, 343 };
            Assert.AreEqual(Lib.Array.SignsOfDivisibilityByThree(x), 8);
        }
        [TestMethod]
        public void TestSignsOfDivisibilityByFive()
        {
            float[] x = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 10, 11, -1, -30, -4040450, 2334243, 33, 3, 343 };
            Assert.AreEqual(Lib.Array.SignsOfDivisibilityByFive(x), 5);
        }
        [TestMethod]
        public void TestSignsOfDivisibilityByTen()
        {
            float[] x = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 10, 11, -1, -30, -4040450, 2334243, 33, 3, 343 };
            Assert.AreEqual(Lib.Array.SignsOfDivisibilityByTen(x), 4);
        }
    }
}
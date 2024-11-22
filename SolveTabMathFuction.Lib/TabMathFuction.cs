namespace SolveTabMathFuction.Lib
{
    public static class TabMathFuction
    {
        public static double[] CalculateTabMathFuction(int startValue, int stopValue)
        {
            var res = new double[10];
            double x = startValue;
            for (int i = 0; i < 10; i++)
            {
                x =+i * (double)(stopValue - startValue) / 10;
                res[i] = Math.Round((1.0 + Math.Sin(Math.Sqrt(x * x + 1.0))) / (Math.Cos((12.0 * x - 4.0))), 2);
            }
            return res;
        }
    }
}

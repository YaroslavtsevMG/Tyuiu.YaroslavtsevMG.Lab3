namespace SolveMathFirstExpression.Lib
{
    public static class MathFirstExpression
    {
        public static float CalculateFirstExpression(double arg1, double arg2, double arg3)
        {
            var x = (float)arg1;
            var y = (float)arg2;
            var a = (float)arg3;
            return 6 * y - (((a + 3) / x) / ((2 - x * a) / (x * y))) + (2 + 3 * a) / (10 * x + 3 * a) + 4 * y;
        }
    }
}

namespace SolveMathSecondExpression.Lib
{
    public static class MathSecondExpression
    {
        public static float CalculateSecondExpression(double x, double y, double a)
        {
            return 2 * (float)y + (2 + 3 * (float)a) / (10 * (float)x - 3 * (float)a) + 2 * (float)a + (((float)a / (float)y) / (3 * (float)a / (float)x));
        }
    }
}

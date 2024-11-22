namespace SolveArray.Lib
{
    public static class Array
    {
        public static float CalculateMinimum(float[] array)
        {
            return array.Min();
        }
        public static float CalculateMaximum(float[] array)
        {
            return array.Max();
        }
        public static float CalculateAverage(float[] array)
        {
            return array.Average();
        }
        public static float CalculateMedian(float[] array)
        {
            bool s = true;
            int sortedEnd = 0;
            float box;
            while(s)
            {
                s = false;
                for(int i=1;i<array.Length-sortedEnd;i++)
                {
                    if (array[i - 1] > array[i])
                    {
                        box = array[i - 1];
                        array[i - 1] = array[i];
                        array[i] = box;
                        s = true;
                        
                    }
                    
                }
                sortedEnd = sortedEnd + 1;
            }
            if(array.Length%2==0)
            {
                return (array[array.Length / 2] + array[array.Length / 2 - 1]) / 2;
            }
            return array[array.Length / 2];
        }
        public static int CalculateNumberOfEven(float[] array)
        {
            int res = 0;
            for(int i=0;i<array.Length;i++)
            {
                if (array[i]%2==0)
                {
                    res = res + 1;
                }
            }
            return res;
        }
        public static int CalculateNumberOfOdd(float[] array)
        {
            int res = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    res = res + 1;
                }
            }
            return res;
        }
        public static int SignsOfDivisibilityByTwo(float[] array)
        {
            int res = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    res = res + 1;
                }
            }
            return res;
        }
        public static int SignsOfDivisibilityByThree(float[] array)
        {
            int res = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 3 == 0)
                {
                    res = res + 1;
                }
            }
            return res;
        }
        public static int SignsOfDivisibilityByFive(float[] array)
        {
            int res = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 5 == 0)
                {
                    res = res + 1;
                }
            }
            return res;
        }
        public static int SignsOfDivisibilityByTen(float[] array)
        {
            int res = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 10 == 0)
                {
                    res = res + 1;
                }
            }
            return res;
        }
    }
}

namespace Sqrt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MySqrt(90);
        }

        public static int MySqrt(int x)
        {
            if (x < 2)
                return x;

            int left = 1, right = x / 2, result = 0;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                long square = (long)mid * mid;

                if (square == x)
                    return mid;
                else if (square < x)
                {
                    result = mid;
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return result;
        }
    }
}

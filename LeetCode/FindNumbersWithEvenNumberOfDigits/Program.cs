namespace FindNumbersWithEvenNumberOfDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FindNumbers([12, 345, 2, 6, 7896]);
        }

        public static int FindNumbers(int[] nums)
        {
            int evenCount = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int count = 0;

                while (nums[i] != 0)
                {
                    nums[i] = nums[i] / 10;
                    count++;
                }

                if (count % 2 == 0)
                {
                    evenCount++;
                }

            }
            return evenCount;
        }
    }
}

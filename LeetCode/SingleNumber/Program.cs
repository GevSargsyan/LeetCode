namespace SingleNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SingleNumberV2([4, 1, 2, 1, 2]);
        }

        public static int SingleNumber(int[] nums)
        {
            Dictionary<int, bool> keyValuePairs = new Dictionary<int, bool>();

            for (int i = 0; i <= nums.Length - 1; i++)
            {
                if (!keyValuePairs.ContainsKey(nums[i]))
                {
                    keyValuePairs.Add(nums[i], true);
                }
                else
                {
                    keyValuePairs[nums[i]] = false;
                }
            }

            return keyValuePairs.First(x => x.Value).Key;
        }

      public static int SingleNumberV2(int[] nums)
        {
            int result = 0;
            foreach (int num in nums)
            {
                result ^= num;
            }
            return result;
        }
    }
}

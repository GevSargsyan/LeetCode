namespace ContainsDuplicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContainsDuplicate([1, 2, 3, 1]);
        }

        public static bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();

            for (int i = 0; i <= nums.Length - 1; i++)
            {
                if (!set.Contains(nums[i]))
                {
                    set.Add(nums[i]);
                }
                else
                {
                    return true;
                }
            }

            return false;

        }
    }
}

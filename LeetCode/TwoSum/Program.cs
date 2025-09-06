namespace TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = TwoSumHashSet([3, 4, 7, 1], 7);
        }

        public static int[] TwoSum(int[] nums, int target)//Time : O(n^2)
        {
            for (int i = 0; i < nums.Length; i++) 
            {
                for (int j = i + 1 ; j < nums.Length; j++) 
                {
                    if (nums[j] + nums[i] == target)
                    {
                        return [i,j];
                    }
                }
            
            }

            return [0, 0];
        }

        public static int[] TwoSumHashSet(int[] nums, int target)//Time : O(n) 3 4 7 1 , 7
        {
            Dictionary<int, int> valuePairs = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int n = target - nums[i];
                if (valuePairs.ContainsKey(n))
                {
                    return new int[] { valuePairs[n], i };
                }
                if (!valuePairs.ContainsKey(nums[i]))
                {
                    valuePairs.Add(nums[i], i);
                }
            }
            return [];
        }
    }
}

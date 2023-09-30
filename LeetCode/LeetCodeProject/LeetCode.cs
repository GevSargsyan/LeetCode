namespace LeetCodeProject
{
    internal static class LeetCode
    {

        #region TwoSum
        //Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
        //You may assume that each input would have exactly one solution, and you may not use the same element twice.
        //You can return the answer in any order.

        public static int[] TwoSum(int[] nums, int target)//Time : O(n^2)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i; j < nums.Length; j++)
                {
                    if (i != j)
                    {
                        if (nums[i] + nums[j] == target)
                        {
                            return new int[] { i, j };
                        }
                    }
                }
            }
            return new int[] { };
        }

        public static int[] TwoSumHashSet(int[] nums, int target)//Time : O(n)
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
            return new int[] { };
        }

        #endregion

    }
}

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

        #region Palindrome
        // Given an integer x, return true if x is a palindrome , and false otherwise.
        public static bool IsPalindromeUsingToString(int x)//111141111
        {
            string s = x.ToString();
            for (int i = 0, j = s.Length - 1; i != j && j > 0; i++, j--)
            {
                if (s[i] != s[j]) return false;
            }
            return true;
        }

        public static bool IsPalindrome(int x)//1234
        {
            if (x < 0 || (x != 0 && x % 10 == 0)) return false;

            int temp = 0;
            int num = x;

            while (num > 0)
            {
                temp = temp * 10 + num % 10;
                num /= 10;
            }
            //0 * 10 + 4
            //4 * 10 + 3
            //43 * 10 + 2
            //432 * 10 + 1
            //4321
            return temp == x;

        }

        public static bool IsPalindromeHalf(int x)
        {

            if (x < 0 || (x != 0 && x % 10 == 0)) return false;

            int reversed = 0;
            while (x > reversed)
            {
                reversed = reversed * 10 + x % 10;
                x /= 10;
            }
            return (x == reversed) || (x == reversed / 10);

        }

        public static bool IsPalindromeUsingArrayReverse(int x)
        {
            if (x < 0 || (x != 0 && x % 10 == 0)) return false;

            var numStr = x.ToString();
            var reverse = new string(numStr.ToCharArray().Reverse().ToArray());
            return numStr == reverse;
        }


        #endregion
    }
}

using System.Diagnostics;
using System.Text;

namespace LeetCodeProject
{
    internal static class LeetCode
    {
        #region Properties
        private static Stopwatch Watch { get; set; }
        #endregion

        #region Ctor
        static LeetCode()
        {
            Watch = new Stopwatch();
        }
        #endregion

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

        #region LongestCommonPrefix
        public static string LongestCommonPrefix(string[] strs)//new string[] { "flower", "flow", "flight" }
        {
            if (strs.Length == 0) return "";
            string prefix = strs[0];

            for (int i = 1; i < strs.Length; i++)
            {
                while (strs[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    if (string.IsNullOrEmpty(prefix)) return "";
                }
            }

            return prefix;
        }

        public static string LongestCommonPrefixWithSorting(string[] strs)//new string[] { "flower", "flow", "flight" }
        {
            if (strs == null || strs.Length == 0)
                return "";

            Array.Sort(strs);

            string firstStr = strs[0];
            string lastStr = strs[^1];

            int minLength = Math.Min(firstStr.Length, lastStr.Length);
            int commonLength = 0;

            for (int i = 0; i < minLength; i++)
            {
                if (firstStr[i] == lastStr[i])
                {
                    commonLength++;
                }
                else
                {
                    break;
                }
            }

            return firstStr[..commonLength];
        }
        #endregion

        #region LongestSubstringWithoutRepeatingCharacters

        public static int LengthOfLongestSubstring(string s)//"abcabcbb"
        {
            Watch.Start();

            if (string.IsNullOrEmpty(s))
                return 0;

            HashSet<int> hashset = new HashSet<int>();
            StringBuilder temp = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                temp.Append(s[i]);
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[i] != s[j] && !temp.ToString().Contains(s[j]))
                    {
                        temp.Append(s[j]);
                    }
                    else
                    {
                        break;
                    }
                }
                hashset.Add(temp.Length);
                temp.Clear();
            }

            Watch.Stop();
            Console.WriteLine($"Elapsed Time: LengthOfLongestSubstring {Watch.ElapsedMilliseconds} ms");
            Watch.Reset();
            return hashset.Max(x => x);
        }

        public static int LengthOfLongestSubstringHashSet(string s)//"abcbbcbb"
        {
            Watch.Start();
            int n = s.Length;
            int maxLength = 0;
            HashSet<char> charSet = new HashSet<char>();
            int left = 0;

            for (int right = 0; right < n; right++)
            {
                if (!charSet.Contains(s[right]))
                {
                    charSet.Add(s[right]);
                    maxLength = Math.Max(maxLength, right - left + 1);
                }
                else
                {
                    while (charSet.Contains(s[right]))
                    {
                        charSet.Remove(s[left]);
                        left++;
                    }
                    charSet.Add(s[right]);
                }
            }
            Thread.Sleep(3000);
            Watch.Stop();
            Console.WriteLine($"Elapsed Time: LengthOfLongestSubstringHashet {Watch.ElapsedMilliseconds} ms");
            Watch.Reset();
            return maxLength;
        }



        #endregion
    }
}

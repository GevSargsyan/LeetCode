using System.Collections.Generic;
using System.Xml;
using System.Xml.Linq;

namespace RemoveDuplicatesFromSortedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums  = [1,1,1];
            RemoveDuplicates(nums);
        }


        //Input: nums = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4]
        //Output: 5, nums = [0, 1, 2, 3, 4, _, _, _, _, _]
        //Explanation: Your function should return k = 5,
        //with the first five elements of nums being 0, 1, 2, 3, and 4 respectively.
        public static int RemoveDuplicates(int[] nums)
        {

            int counter = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] != nums [i+1]) 
                {
                    nums[counter++] = nums[i];
                }
            }
          
            if (counter != 0 && nums[counter - 1] != nums[nums.Length - 1])
            {
                nums[counter++] = nums[nums.Length - 1];
            }

            return counter;

        }
    }
}

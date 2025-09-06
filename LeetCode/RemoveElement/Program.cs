namespace RemoveElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [0, 1, 2, 2, 3, 0, 4, 2];
            var a = RemoveElement(nums, 2);

        }


        //Input: nums = [0, 1, 2, 2, 3, 0, 4, 2], val = 2
        //Output: 5, nums = [0, 1, 4, 0, 3, _, _, _]
        //Explanation: Your function should return k = 5,
        //with the first five elements of nums containing 0, 0, 1, 3, and 4.
        public static int RemoveElement(int[] nums, int val)
        {
            int counter = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == val)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[j] == val)
                        {
                            continue;
                        }
                        else
                        {
                            int temp = nums[i];
                            nums[i] = nums[j];
                            nums[j] = temp;
                            counter++;
                            break;
                        }
                    }
                }
                else
                {
                    counter++;

                }

            }

            return counter;
        }
    }
}

namespace SearchInsertPosition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SearchInsert([1,3,5,6],0);
        }

        public static int SearchInsert(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            int mid = 0;
            while (left < right) 
            {
                mid = (left + right) / 2;

                if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else 
                {
                    right = mid;
                }
                
            }

            return target > nums[nums.Length - 1] ? left + 1 : left;

        }
    }
}

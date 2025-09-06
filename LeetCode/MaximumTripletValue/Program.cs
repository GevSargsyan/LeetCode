namespace MaximumTripletValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Combine("abc");
            //Console.WriteLine(MaximumTripletValue([12, 6, 1, 2, 7]));
        }

        static long MaximumTripletValue(int[] nums)
        {

            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length - 1; j++)
                {
                    for (int k = j + 1; k < nums.Length - 1; k++)
                    {
                        Console.WriteLine($" i = {i} = {nums[i]}{Environment.NewLine} j = {j} = {nums[j]}{Environment.NewLine} k = {k} = {nums[k]} {Environment.NewLine} {(nums[i] - nums[j]) * nums[k]}");
                    }
                }
            }

            return 0;
        }

        static void Combine(string s)
        {



        }
    }
}

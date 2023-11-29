namespace LeetCodeProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint inputValue = Convert.ToUInt32("11111111111111111111111111111101", 2);
            Console.WriteLine(LeetCode.HammingWeight2(inputValue));
        }
    }
}
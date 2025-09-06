namespace FirstOccurrence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StrStr("leetcode", "cod"));
        }

        public static int StrStr(string haystack, string needle)
        {
            ReadOnlySpan<char> haystackSpan = haystack.AsSpan();
            ReadOnlySpan<char> needleSpan = needle.AsSpan();

            for (int i = 0; i <= haystackSpan.Length - needleSpan.Length; i++)
            {
                if (haystackSpan.Slice(i, needleSpan.Length).SequenceEqual(needleSpan))
                {
                    return i;
                }
            }

            return -1;
        }
    }
}

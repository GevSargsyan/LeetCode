namespace LongestCommonPrefix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LongestCommonPrefixWithSorting(["flower", "flow", "flight"]);

        }
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
    }
}

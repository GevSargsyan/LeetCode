namespace LengthOfLastWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LengthOfLastWord("   fly me   to   the moon  "));
        }

        public static int LengthOfLastWord(string s)
        {
            int length = 0;
            for (int i = s.Length - 1; i >= 0; i--) 
            {
                if (s[i] != ' ')
                {
                    length++;
                    continue;
                }

                if ((s[i] == ' ' && i == s.Length - 1) || (s[i] == ' ' && s[i + 1] == ' '))
                {
                    continue;
                }

                if (s[i] == ' ') 
                {
                    return length;
                }
            }
            return length;
        }
    }
}

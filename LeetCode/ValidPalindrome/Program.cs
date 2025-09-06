using System.Text;

namespace ValidPalindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IsPalindrome(" ");
        }

        public static bool IsPalindrome(string s)
        {
            StringBuilder builder = new StringBuilder();
            bool result = true;

            for (int i = 0; i <= s.Length - 1; i++)
            {
                if (((int)s[i] >= 48 && (int)s[i] <= 57) || ((int)s[i] >= 65 && (int)s[i] <= 90) || ((int)s[i] >= 97 && (int)s[i] <= 122))
                {
                    builder.Append(char.ToLower(s[i]));
                }
            }

            int k = 0;
            int j = builder.Length - 1;
            while (k < builder.Length / 2)
            {
                if (builder[k] != builder[j])
                {
                    return false;
                }
                k++;
                j--;
            }

            return result;
        }

        public static bool IsPalindromeV2(string s)
        {
            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                while (left < right && !char.IsLetterOrDigit(s[left])) left++;
                while (left < right && !char.IsLetterOrDigit(s[right])) right--;

                if (char.ToLower(s[left]) != char.ToLower(s[right]))
                    return false;

                left++;
                right--;
            }

            return true;
        }
    }
}

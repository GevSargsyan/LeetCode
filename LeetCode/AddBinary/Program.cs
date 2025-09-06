using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AddBinary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddBinaryV2("1010", "1011");
            
        }

        public static string AddBinary(string a, string b)
        {
            int aInt = 0;
            int bInt = 0;

            for (int i = 0; i < a.Length; i++)
            {
                aInt = aInt * 2 + (a[i] - '0');
            }

            for (int i = 0; i < b.Length; i++)
            {
                bInt = bInt * 2 + (b[i] - '0');
            }

            int res = aInt + bInt;
            string binary = "";

            while (res > 0)
            {
                int remainder = res % 2;
                binary = remainder + binary; 
                res /= 2;
            }

            return string.IsNullOrEmpty(binary) ? "0" : binary;
        }

        public static string AddBinaryV2(string a, string b)
        {

            int i = a.Length - 1;
            int j = b.Length - 1;
            int carry = 0;
            var result = new System.Text.StringBuilder();

            while (i >= 0 || j >= 0 || carry > 0)
            {
                int bitA = i >= 0 ? a[i] - '0' : 0;
                int bitB = j >= 0 ? b[j] - '0' : 0;

                int sum = bitA + bitB + carry;
                result.Insert(0, sum % 2); 
                carry = sum / 2;

                i--;
                j--;
            }

            return result.ToString();
        }
    }
}

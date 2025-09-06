using System.Data.Common;
using System.Text;

namespace AddStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 19; i++) 
            //{
            //    Console.WriteLine($"{i} - {i%10}");
            //}
            Console.WriteLine(AddStrings("584", "18"));
        }

        public static string AddStrings(string num1, string num2)
        {
            int num1Length = num1.Length;
            int num2Length = num2.Length;
            int indexer = num1.Length > num2.Length ? num1.Length - 1 : num2.Length - 1;
            char[] arr = new char[indexer + 1];
            char[]? extraArr = null;
            bool needToIncrement = false;

            while (indexer >= -1)
            {
                char num1Index = '0';
                char num2Index = '0';


                if (num1Length > 0)
                {
                    if (num1.Length < num2.Length)
                    {
                        num1Index = num1[indexer - (num2.Length - num1.Length)];
                    }
                    else
                    {
                        num1Index = num1[indexer];
                    }
                }

                if (num2Length > 0)
                {
                    if (num2.Length < num1.Length)
                    {
                        num2Index = num2[indexer - (num1.Length - num2.Length)];
                    }
                    else
                    {
                        num2Index = num2[indexer];
                    }
                }

                int sum = needToIncrement ? ((num1Index - 48) + (num2Index - 48) + 1) % 10 : ((num1Index - 48) + (num2Index - 48)) % 10;
                if (indexer == -1 && sum != 0)
                {
                    extraArr = new char[arr.Length + 1];
                    Array.Copy(arr, 0, extraArr, 1, arr.Length);
                    extraArr[0] = (char)(sum + 48);
                }
                else 
                {
                    if (indexer != -1)
                    {
                        arr[indexer] = (char)(sum + 48);
                    }
                }


                needToIncrement = (needToIncrement && (num1Index - 48) + (num2Index - 48) + 1 > 9 ) || (num1Index - 48) + (num2Index - 48) > 9 || (needToIncrement && (num1Index - 48 == 9 || num2Index - 48 == 9)) ;

                num1Length--;
                num2Length--;
                indexer--;

            }


            return new string(indexer == -2 && extraArr != null ? extraArr : arr);
        }
         

        public static string AddStringsV2(string num1, string num2)
        { 

            var res = new StringBuilder();
            int i = num1.Length - 1;
            int j = num2.Length - 1;
            int carry = 0;
            while (i >= 0 || j >= 0 || carry > 0)
            {
                int d1 = i >= 0 ? num1[i] - '0' : 0;
                int d2 = j >= 0 ? num2[j] - '0' : 0;
                int sum = d1 + d2 + carry;
                carry = sum / 10;
                res.Append((char)((sum % 10) + '0'));
                i--; j--;
            }
            var charArray = res.ToString().ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

    }
}

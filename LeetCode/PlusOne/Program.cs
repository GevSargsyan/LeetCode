namespace PlusOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlusOneV2([1,3]);
        }


        /*
         9939
         9940

         9999
         10000

         9899
         9900

         5



         */


        public static int[] PlusOneV2(int[] digits)
        {
            var extra = 1;
            for (var i = digits.Length - 1; i >= 0; i--)
            {
                var digit = digits[i];
                var tmp = digit + extra;
                digits[i] = tmp % 10;
                extra = tmp / 10;
            }

            var result = digits;
            if (extra != 0)
            {
                result = new int[digits.Length + 1];
                result[0] = extra;
                Array.Copy(digits, 0, result, 1, digits.Length);
            }

            return result;
        }

        public static int[] PlusOne(int[] digits)
        {
            bool increment = true;
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] != 9)
                {
                    increment = false;
                    break;
                }
            }

            int [] arr = new int[increment ? digits.Length + 1 : digits.Length];

            bool isContinue = false;
            for (int i = digits.Length - 1, j = 0; j <= arr.Length - 1 ; i--,j++)
            {
                if (j > digits.Length - 1)
                {
                    arr[0] = 1;
                    break;
                }

                if (digits[i] == 9 && !isContinue)
                {
                    if (increment)
                    {
                        arr[i + 1] = 0;
                    }
                    else
                    {
                        arr[i] = 0;
                    }
                }
                else
                {
                    if (increment)
                    {
                        if (!isContinue)
                        {
                            arr[i + 1] = digits[i] + 1;

                        }
                        else
                        {
                            arr[i + 1] = digits[i];

                        }
                    }
                    else
                    {
                        if (!isContinue)
                        {
                            arr[i] = digits[i] + 1;

                        }
                        else 
                        {
                            arr[i] = digits[i];
                        }
                    }
                    isContinue = true;
                }
            }

            return arr;
        }
    }
}

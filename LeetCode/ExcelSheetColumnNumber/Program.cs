namespace ExcelSheetColumnNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double d = 0.1 + 0.2;
            bool b = 0.1 + 0.2 == 0.3;
            Console.WriteLine(8>>2);
            Console.WriteLine(TitleToNumber("ABC"));
        }

        public static int TitleToNumber(string columnTitle)
        {
            int sum = 0;
            for (int i = columnTitle.Length - 1, iterator = 0; i >= 0; i--, iterator++)
            {
                sum += (columnTitle[i] - 64) * (int)Math.Pow(26,iterator) ;
            }

            return sum;
        }
    }
}
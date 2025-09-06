namespace ExcelSheetColumnTitle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConvertToTitle(1);
        }

        public static string ConvertToTitle(int columnNumber)
        {
            string result = "";

            while (columnNumber > 0) 
            {
                columnNumber--;
                result += ((char)(columnNumber % 26 + 65));
                columnNumber = columnNumber / 26;
            }

            return result;
        }
    }
}
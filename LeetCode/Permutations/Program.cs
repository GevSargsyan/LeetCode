namespace Permutations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] elements = { 'a', 'b', 'c' }; // Example set



            List<List<char>> permutations = GetPermutations(elements);

            Console.WriteLine("Permutations:");
            foreach (var perm in permutations)
            {
                Console.WriteLine(string.Join("", perm));
            }
        }


        /*
          char[] elements = { 'a', 'b', 'c','d' }; 
              abcd
              abdc
              acbd
              acdb
              adcb
              adbc
              
        */

        static List<List<T>> GetPermutations<T>(T[] elements)
        {
            List<List<T>> result = new List<List<T>>();
            Permute(elements, 0, result);
            return result;
        }

        static void Permute<T>(T[] elements, int start, List<List<T>> result)
        {
            if (start == elements.Length - 1)
            {
                result.Add(new List<T>(elements));
                return;
            }

            for (int i = start; i < elements.Length; i++)
            {
                Swap(ref elements[start], ref elements[i]); // Swap current element
                Permute(elements, start + 1, result);       // Recursive call
                Swap(ref elements[start], ref elements[i]); // Backtrack (undo swap)
            }
        }

        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}

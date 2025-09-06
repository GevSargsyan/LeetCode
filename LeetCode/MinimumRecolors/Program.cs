using System.Security;

namespace MinimumRecolors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MinimumRecolors2("BWWBWWBBBW", 4);
        }

        public static int MinimumRecolors(string blocks, int k)
        {
            Queue<char> blockQueue = new Queue<char>();
            short numWhites = 0;

            // Initiate queue with first k values
            for (int i = 0; i < k; i++)
            {
                char currentChar = blocks[i];
                if (currentChar == 'W') numWhites++;
                blockQueue.Enqueue(currentChar);
            }

            // Set initial minimum
            int numRecolors = numWhites;

            for (int i = k; i < blocks.Length; i++)
            {
                // Remove front element from queue and update current number of white blocks
                if (blockQueue.Dequeue() == 'W')
                { 
                    numWhites--;
                }

                // Add current element to queue and update current number of white blocks
                char currentChar = blocks[i];
                if (currentChar == 'W')
                {
                    numWhites++;
                } 
                blockQueue.Enqueue(currentChar);

                // Update minimum
                numRecolors = Math.Min(numRecolors, numWhites);
            }
            return numRecolors;
        }
        public static int MinimumRecolors2(string blocks, int k)
        {
            int ans = Int32.MaxValue;
            int wCount = 0;

            for (int i = 0; i < blocks.Length; i++)
            {
                if (blocks[i] == 'W')
                {
                    wCount++;
                }

                if (i + 1 >= k)
                {
                    ans = Math.Min(ans, wCount);
                    if (blocks[i - k + 1] == 'W')
                    {
                        wCount--;
                    }
                }
            }

            return ans;
        }
    }
}

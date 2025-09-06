using System.Data.Common;

namespace MatrixProcess
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.Clear();

            int columnCount = 30;
            List<Task> tasks = new();

            for (int i = 0; i < columnCount; i++)
            {
                int delay = Random.Shared.Next(0, 1500);
                int left = Random.Shared.Next(0, Console.WindowWidth);
                tasks.Add(StartColumnRain(left, delay));
            }

            await Task.WhenAll(tasks);
        }

        static async Task StartColumnRain(int column, int startDelay)
        {
            await Task.Delay(startDelay);

            int height = Console.WindowHeight;
            var trail = new Queue<(int Top, char Char, int Age)>();

            while (true)
            {
                char headChar = (char)Random.Shared.Next(33, 126);
                int row = trail.Count == 0 ? 0 : trail.Last().Top + 1;

                if (row >= height)
                {
                    //await Task.Delay(Random.Shared.Next(500, 1500));
                    ClearTrail(trail, column);
                    trail.Clear();
                    row = 0;
                }

                trail.Enqueue((row, headChar, 0));

                lock (Console.Out)
                {
                    foreach (var (Top, Char, Age) in trail)
                    {
                        Console.SetCursorPosition(column, Top);
                        if (Age == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else if (Age == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        else if (Age < 10)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                        }

                        Console.Write(Age < 10 ? Char : ' ');
                    }
                }


                var aged = trail.Select(t => (Top: t.Top, Char: t.Char, Age: t.Age + 1)).ToList();
                trail.Clear();
                foreach (var item in aged.Where(t => t.Age <= 10))
                    trail.Enqueue(item);

                await Task.Delay(100);
            }
        }

        static void ClearTrail(IEnumerable<(int Top, char Char, int Age)> trail, int column)
        {
            lock (Console.Out)
            {
                foreach (var (Top, _, _) in trail)
                {
                    Console.SetCursorPosition(column, Top);
                    Console.Write(" ");
                }
            }
        }
    }

    //internal class Program
    //{
    //    static async Task Main(string[] args)
    //    {
    //        Console.CursorVisible = false;
    //        Console.ForegroundColor = ConsoleColor.Green;

    //        int columnCount = 2;
    //        List<Task> tasks = [];

    //        for (int i = 0; i < columnCount; i++)
    //        {
    //            int delay = Random.Shared.Next(0, 1000);  
    //            int left = Random.Shared.Next(0, Console.WindowWidth);
    //            tasks.Add(StartColumnRain(left, delay));
    //        }

    //        await Task.WhenAll(tasks);
    //    }

    //    static async Task StartColumnRain(int column, int startDelay)
    //    {
    //        await Task.Delay(startDelay);

    //        int height = Console.WindowHeight;

    //        while (true) // loop forever to simulate continuous rain
    //        {
    //            for (int row = 0; row < height; row++)
    //            {
    //                lock (Console.Out)  
    //                {
    //                    Console.SetCursorPosition(column, row);
    //                    Console.Write((char)Random.Shared.Next(33, 126));  
    //                }
    //                await Task.Delay(100);
    //            }

    //            await Task.Delay(Random.Shared.Next(500, 1500));

    //            for (int row = 0; row < height; row++)
    //            {
    //                lock (Console.Out)
    //                {
    //                    Console.SetCursorPosition(column, row);
    //                    Console.Write(" ");
    //                }
    //            }
    //        }
    //    }


    //}

    //class Program
    //{

    //    static async Task Main(string[] args)
    //    {
    //        Console.CursorVisible = false;
    //        Console.Clear();

    //        int columnCount = 40;
    //        List<Task> tasks = new();

    //        for (int i = 0; i < columnCount; i++)
    //        {
    //            int delay = Random.Shared.Next(0, 1500);
    //            int left = Random.Shared.Next(0, Console.WindowWidth);
    //            tasks.Add(StartColumnRain(left, delay));
    //        }

    //        await Task.WhenAll(tasks);
    //    }

    //    static async Task StartColumnRain(int column, int startDelay)
    //    {
    //        await Task.Delay(startDelay);

    //        int height = Console.WindowHeight;
    //        List<(int Top, char Char)> trail = new();

    //        while (true)
    //        {
    //            for (int row = 0; row < height; row++)
    //            {
    //                char randomChar = (char)Random.Shared.Next(33, 126);
    //                trail.Add((row, randomChar));

    //                lock (Console.Out)
    //                {
    //                    for (int i = 0; i < trail.Count; i++)
    //                    {
    //                        int pos = trail[i].Top;
    //                        char ch = trail[i].Char;

    //                        Console.SetCursorPosition(column, pos);

    //                        if (i == trail.Count - 1)
    //                        {
    //                            Console.ForegroundColor = ConsoleColor.White; // Head
    //                        }
    //                        else if (i >= trail.Count - 3)
    //                        {
    //                            Console.ForegroundColor = ConsoleColor.Green; // Mid
    //                        }
    //                        else
    //                        {
    //                            Console.ForegroundColor = ConsoleColor.DarkGreen; // Tail
    //                        }

    //                        Console.Write(ch);
    //                    }
    //                }

    //                if (trail.Count > 20)
    //                {
    //                    var removed = trail[0];
    //                    trail.RemoveAt(0);
    //                    lock (Console.Out)
    //                    {
    //                        Console.SetCursorPosition(column, removed.Top);
    //                        Console.Write(" ");
    //                    }
    //                }

    //                await Task.Delay(100);
    //            }

    //            await Task.Delay(Random.Shared.Next(500, 1500));
    //            foreach (var (top, _) in trail)
    //            {
    //                lock (Console.Out)
    //                {
    //                    Console.SetCursorPosition(column, top);
    //                    Console.Write(" ");
    //                }
    //            }
    //            trail.Clear();
    //        }
    //    }
    //}


}

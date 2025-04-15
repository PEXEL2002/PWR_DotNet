using System.Collections.Specialized;
using System.Security.Cryptography;

namespace Console_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int[] sizes = { 500, 750, 1000};
            int[] threads = { 1, 2, 4, 6, 8 };
            int j = 1;
            int partTimeParallel = 0;
            int partTimeThreads = 0;
            Console.WriteLine("| Lp. | Or Average | Matrix dimension | Number of Threads | Parallel/Threads | Time |");
            foreach(var size in sizes)
            {
                foreach (var threadN in threads) 
                {
                    int timeParallel = 0;
                    int timeThreads = 0;
                    for (int i = 0; i < n; i++)
                    {
                        Matrix A = new Matrix(size, size);
                        Matrix B = new Matrix(size, size);
                        partTimeParallel = A.MultiplyMatrixParallel(B, threadN, false);
                        Console.WriteLine($"| {j++} | 0 | {size}x{size} | {threadN} |  Parallel | {partTimeParallel} |");
                        partTimeThreads = A.MultiplyMatrixThread(B, threadN, false);
                        Console.WriteLine($"| {j++} | 0 | {size}x{size} | {threadN} |  Threads | {partTimeThreads} |");
                        timeParallel += partTimeParallel;
                        timeThreads += partTimeThreads;
                    }
                    Console.WriteLine($"| {j++} | 1 | {size}x{size} | {threadN} |  Parallel | {timeParallel/n} |");
                    Console.WriteLine($"| {j++} | 1 | {size}x{size} | {threadN} |  Threads | {timeThreads/n} |");
                }
            }

        }
    }
}

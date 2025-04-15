using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App
{
    class Matrix
    {
        public int[,] matrix;
        public int rows;
        public int columns;
        public Matrix(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            matrix = new int[rows, columns];
        }
        public void GenMatrix(int min_random, int max_random)
        {
            Random rand = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = rand.Next(min_random, max_random);
                }
            }
        }
        public void PrintMatrix()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public void PrintMatrixMultiply(int[,] result)
        {
            Console.WriteLine("Result of matrix multiplication:");
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    Console.Write(result[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public int MultiplyMatrixThread(Matrix mat, int num_of_thread, bool ifPrint)
        {
            int time = 0;
            if (this.columns != mat.rows)
            {
                Console.WriteLine("Matrix multiplication is impossible.");
                return time;
            }
            int[,] result = new int[this.rows, mat.columns];
            DateTime start = DateTime.Now;
            Thread[] threads = new Thread[num_of_thread];
            int rowsPerThread = this.rows / num_of_thread;
            for (int t = 0; t < num_of_thread; t++)
            {
                int startRow = t * rowsPerThread;
                int endRow = (t == num_of_thread - 1) ? this.rows : startRow + rowsPerThread;
                threads[t] = new Thread(() => MultiplyRows(startRow, endRow, mat, result));
                threads[t].Start();
            }
            foreach (var thread in threads)
            {
                thread.Join();
            }
            DateTime end = DateTime.Now;
            TimeSpan duration = end - start;
            time = (int)duration.TotalMilliseconds;
            if (ifPrint)
            {
                 Console.WriteLine("Time taken: " + time + " ms");
                 PrintMatrixMultiply(result);
            }

            return time;
        }
        private void MultiplyRows(int startRow, int endRow, Matrix mat, int[,] result)
        {
            for (int i = startRow; i < endRow; i++)
            {
                for (int j = 0; j < mat.columns; j++)
                {
                    result[i, j] = 0;
                    for (int k = 0; k < this.columns; k++)
                    {
                        result[i, j] += this.matrix[i, k] * mat.matrix[k, j];
                    }
                }
            }
        }

        public int MultiplyMatrixParallel(Matrix mat, int num_of_thread, bool ifPrint)
        {
            int time = 0;
            if (this.columns != mat.rows)
            {
                Console.WriteLine("Mnożenie macierzy jest niemożliwe.");
                return time;
            }
            int[,] result = new int[this.rows, mat.columns];
            DateTime start = DateTime.Now; 
            ParallelOptions parallelOptions = new ParallelOptions
            {
                MaxDegreeOfParallelism = num_of_thread 
            };
            Parallel.For(0, this.rows, parallelOptions, i =>
            {
                for (int j = 0; j < mat.columns; j++) 
                {
                    result[i, j] = 0; 
                    for (int k = 0; k < this.columns; k++) 
                    {
                        result[i, j] += this.matrix[i, k] * mat.matrix[k, j];
                    }
                }
            });
            DateTime end = DateTime.Now;
            TimeSpan duration = end - start;
            time = (int)duration.TotalMilliseconds;
            if (ifPrint)
            {
                Console.WriteLine("Time taken: " + time + " ms");
                PrintMatrixMultiply(result);
            }
            return time;
        }
    }
}

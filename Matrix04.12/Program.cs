using System;

namespace Lessons
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] Matrix = new int[horizontal, vertical];
            Random random = new Random();
            for (int i = 0; i < horizontal; i++)
            {
                for (int j = 0; j < vertical; j++)
                {
                    Matrix[i, j] = random.Next(0, 100);
                }
            }

            for (int i = 0; i < horizontal; i++)
            {
                for (int j = 0; j < vertical; j++)
                {
                    Console.Write(Matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
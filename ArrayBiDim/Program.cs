using System;

namespace ArrayBiDim
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines, columns;
            float[,] matrix;

            string inp;

            // get dimensions from user
            Console.WriteLine("Enter number of lines:");
            inp = Console.ReadLine();
            lines = int.Parse(inp);

            Console.WriteLine("Enter number of columns:");
            inp = Console.ReadLine();
            columns = int.Parse(inp);

            // create array
            matrix = new float[lines, columns];

            // set each element to value from user input
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"[{i}, {j}]: ");
                    inp = Console.ReadLine();
                    matrix[i, j] = float.Parse(inp);
                }
            }
        }
    }
}

using System;

namespace ArrayBiDim
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines, columns;
            float[,] matrix;
            float[] averages;
            float sumOfAverages = 0;

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

            // find average for each line
            averages = new float[lines];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                float sum = 0;

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }

                averages[i] = sum / matrix.GetLength(1);
            }

            // get sum of averages
            foreach (float a in averages)
            {
                sumOfAverages += a;
            }

            // print results
            Console.WriteLine("Averages:");
            for (int i = 0; i < averages.Length; i++)
            {
                Console.WriteLine($"  Line {i}: {averages[i]}");
            }
            Console.WriteLine($"Sum of averages: {sumOfAverages}");
        }
    }
}

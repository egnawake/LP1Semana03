using System;

namespace ArrayBiDim
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines, columns;
            string inp;

            // get dimensions from user
            Console.WriteLine("Enter number of lines:");
            inp = Console.ReadLine();
            lines = int.Parse(inp);

            Console.WriteLine("Enter number of columns:");
            inp = Console.ReadLine();
            columns = int.Parse(inp);
        }
    }
}

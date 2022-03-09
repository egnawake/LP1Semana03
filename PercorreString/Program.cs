using System;

namespace PercorreString
{
    class Program
    {
        static void Main(string[] args)
        {
            string inp, text;
            char excluded;

            // get string from user
            Console.WriteLine("Enter a string:");
            inp = Console.ReadLine();
            text = inp;

            // get char from user
            Console.WriteLine("Enter a single character:");
            inp = Console.ReadLine();
            excluded = char.Parse(inp);

            Console.WriteLine($"User entered: {text}; {excluded}");
        }
    }
}

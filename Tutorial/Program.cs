using System;

namespace Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string response = Console.ReadLine();
            Console.WriteLine("Hello " + response);
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
    }
}

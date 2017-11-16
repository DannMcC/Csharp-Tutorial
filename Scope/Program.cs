using System;

namespace Scope
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables can be assigned the default type using 'var'
            var number = 2;
            var count = 10;
            var totalPrice = 20.95f;
            var character = 'A';
            var firstName = "Dan";
			var isWorking = false;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

            //basic format string,
            Console.WriteLine("{0} {1} {2}", byte.MinValue, byte.MaxValue, "range of a byte");
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            // const makes the data immutable
            const float Pi = 3.14f;

            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
    }
}

using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //IMPLICT TYPE CONVERSION

            //no data loss b/c an int is 4 bytes 
            byte b = 1;
            int i = b;

            // inverse may cause data loss, won't compile i.e.
            //int i = 1;
            //byte b = i;

            //EXPLICT TYPE CONVERSION

            //may cause data loss, will compile
            float f = 1.0f;
            int interger = (int)f;

            //casting a an incorrect type may cause data loss and won't throw an execption 
            //the following will return 232
            int j = 1000;
            byte c = (byte)j;
            Console.WriteLine(c);

            //some types are incompatible, but can be converted
            var number = "1234";
            int k = Convert.ToInt32(number);
            Console.WriteLine(k);

            //If convert type causes overflow, an exception will be thrown
            try
            {
                byte d = Convert.ToByte(number);
                Console.WriteLine(d);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted");
            }

            // True or False can be converted from string, to bool 
            string str = "true";
            bool e = Convert.ToBoolean(str);
            Console.WriteLine(e);

            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
    }
}

using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 57;

            // implicit type conersion
            long l = i;

            // implicit type conversion
            float f = l;

            Console.WriteLine("Integer value: {0}", i);
            Console.WriteLine("Long value: {0}", l);
            Console.WriteLine("Float value: {0}", f);


            double d = 54.7;

            // explicit type casting
            int x = (int) d;
            Console.WriteLine(x);
            
        }
    }
}

using System;


namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 2023;

            // boxing
            object obj = n;

            n = 500;

            Console.WriteLine("Value type: {0}", n);
            Console.WriteLine("Object/Reference Type: {0}", obj);

            // unboxing
            int i = (int) obj;

            // display result
            Console.WriteLine("Unboxxed: {0}", i);
        }
    }
}

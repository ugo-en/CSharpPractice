using System;

namespace IfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 22;


            if (age < 22)
            {
                Console.WriteLine("Too young!");
            }
            else if (age > 22)
            {
                Console.WriteLine("Too old!");
            }
            else
            {
                Console.WriteLine("Just right!");
            }
        }
    }
}



using System;

namespace ForEachStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "James", "Peter", "John" };

            foreach (string name in names)
            {
                Console.WriteLine("{0} is happy today", name);
            }
        }
    }
}
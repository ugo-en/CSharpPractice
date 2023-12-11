using System;


namespace main
{
    class Demo
    {
        static void Main() 
        {
            const double pi = 3.14159;
            double r;
            r = 10.5;
            double area = pi * r * r;

            double circumference = 2 * pi * r;

            Console.WriteLine("Area of the circle is " + area);
            Console.WriteLine("Circumference of the circle is {0}", circumference);
        }
    }
}

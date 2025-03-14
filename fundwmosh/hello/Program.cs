using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            float whoa = 3.22444f;
            decimal whoap = 3.22454m;
            string whoops = "borp";
            bool isFalse = false;
            var mystery = true;
            Console.WriteLine($"Listen, that's clearly {isFalse}. If it were a float, it would be {whoa}, a decimal it would be {whoap}. {whoops}");
            Console.WriteLine($"Now, this one is a mystery. We have one called mystery, which doesn't have a type by default. But, since it's {mystery}, it must be {mystery.GetType()}");
            Console.WriteLine("This is going to be a test of argument interpolation. Value 1 is {0}, Value 2 is {1}", 234, 4222);
            // type casting - implicit
            byte a = 10;
            int b = a;
            // type casting - explicit
            float c = 128.0f;
            int d = (int)c;
            Console.WriteLine("This is a float: {0}, and this is an int: {1}", c, d);

        
        }
    }
}
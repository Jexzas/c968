using System;

namespace classes
{
    public class Bingus
    {
        private string name;
        public Bingus(string n)
        {
            name = n;
        }
        public void introduce()
        {
            Console.WriteLine($"Oi, my name is {name}");
        }

        public static void pig()
        {
            Console.WriteLine("PIG PIG PIG PIG PIG PIG");
        }
    }
}

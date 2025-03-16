namespace classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("gimme ur name bruv");
            string firstGuy = Console.ReadLine() ?? "firstGuy";
            Bingus jim = new Bingus(firstGuy);
            jim.introduce();
            Console.WriteLine("Would you like to execute pig? (y/n)");
            if (Console.ReadLine() == "y")
            {
                Bingus.pig();
            }
        }
    }
}

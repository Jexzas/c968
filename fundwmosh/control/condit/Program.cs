using System; 

namespace Control {
    public class Cflow {
        public static void Main(string[] args) {
            System.Console.WriteLine("This is a switch");
            int bog = 5;
            switch (bog) {
                case 0:
                    System.Console.WriteLine("Bog 0");
                    break;
                case 4:
                    System.Console.WriteLine("Bog 4");
                    break;
                case 26:
                    System.Console.WriteLine("Bog 26");
                    break;
                case 6:
                    System.Console.WriteLine("Bog 6");
                    break;
                case 5:
                    System.Console.WriteLine("Bog 5");
                    break;
                default: 
                    System.Console.WriteLine("NO BOG");
                    break;
            }
            System.Console.WriteLine("This is a ternary");
            float price = (bog == 5) ? 165.5f : 0;
            System.Console.WriteLine($"Price of Bog is {price}");
            System.Console.WriteLine($"It's currently {Season.Summer}?");
            // Valid exercise
            System.Console.WriteLine("Pleas enter a number from 1-10:");
            int valid;
            try {
                valid = Int32.Parse(Console.ReadLine() ?? "0");
            } catch (FormatException e) {
                valid = 0;
                System.Console.WriteLine(e.Message);
            }
            if (valid >= 1 && valid <= 10) {
                System.Console.WriteLine("VALID");
            } else {
                System.Console.WriteLine("NOT VALID");
            }
            // Max 
            System.Console.WriteLine("Enter two numbers:");
            int eins = Int32.Parse(Console.ReadLine() ?? "0");
            int zwei = Int32.Parse(Console.ReadLine() ?? "0");
            System.Console.WriteLine($"The maximum of those two numbers is {Math.Max(eins, zwei)}");
            // PortScape
            System.Console.WriteLine("Enter two numbers. First, enter the height of the image:");
            float height = Convert.ToSingle(Console.ReadLine() ?? "0");
            System.Console.WriteLine("Enter two numbers. First, enter the width of the image:");
            float width = Convert.ToSingle(Console.ReadLine() ?? "0");
            System.Console.WriteLine($"The ratio of the image is {height / width}");
            switch (height > width) {
                case true:
                    System.Console.WriteLine("This is a portrait.");
                    break;
                case false:  
                    if (height == width) {
                        System.Console.WriteLine("This is a square?");
                    } else {
                        System.Console.WriteLine("This is a landscape.");
                    }
                    break;
            }

            // Speeding
            string dems(int travelspeed, int limit) {
                int excess = travelspeed - limit;
                int demerits = excess / 5;
                if (demerits > 12) {
                    return "License Suspended";
                } else {
                    return $"You have received {demerits} points.";
                }
            }

            System.Console.WriteLine("Are you speeding? Never mind that, I'm the police. I'll figure it out.");
            System.Console.WriteLine("Answer me this: What's the speed limit? (mph):");
            int sl = Int32.Parse(Console.ReadLine() ?? "0");
            System.Console.WriteLine("Okay, and how fast were you going?");
            int speed = Int32.Parse(Console.ReadLine() ?? "0");
            if (sl < speed) {
                System.Console.WriteLine(dems(speed, sl));
            } else if (sl >= speed) {
                System.Console.WriteLine("Be on your way, then.");
            }
        }
    }
}
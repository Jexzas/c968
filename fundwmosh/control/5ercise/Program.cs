using System;
using System.Numerics;

namespace Five {
    public static class Five {
        public static void Main(string[] args) {
            
            // exercise 1
            int count = 0;
            for (int i = 0; i <= 100; i++) {
                if (i % 3 == 0) {
                    count++;
                }
            }
            System.Console.WriteLine($"Divisible by 3 up to 100?: {count}");

            // exercise 2
            string input = "";
            int values = 0;
            while (input != "ok") {
                System.Console.WriteLine("Please enter a number:");
                var userInput = Console.ReadLine();
                if (userInput != "ok") {
                    try {
                        values += Int32.Parse(userInput ?? "0");
                    } catch (Exception e) {
                        Console.WriteLine(e + ". That was not a number");
                    }
                } else {
                    input = userInput;
                }
            }
            System.Console.WriteLine($"The final tally of the numbers you entered is {values}.");

            // Exercise 3
            System.Console.WriteLine("Enter a number 12 or less(this is different I swear, I'm gonna give you a factorial):");
            int uput = Int32.Parse(Console.ReadLine() ?? "1");
            List<int> list = new List<int>();
            int total = uput;
            for (int x = uput; x > 0; x--) {
                list.Add(x);
                System.Console.WriteLine(total);
                if (x-1 > 0) {
                    total = total * (x-1);
                }
                System.Console.WriteLine(total);
            }
            System.Console.WriteLine(String.Join("x", list));
            System.Console.WriteLine($"The result of your factorial is: {total}");

            // exercise 4
            Random random = new Random();
            System.Console.WriteLine("Next, we're going to do a random number guesser. Please guess a number between 1 and 15:");
            int guesser = random.Next(1,15);
            int counted = 4;
            for (int x = 1; x <= counted; x++) {
                int guess = Int32.Parse(Console.ReadLine() ?? "0");
                if (guesser == guess) {
                    System.Console.WriteLine("You won!");
                    break;
                } else {
                    System.Console.WriteLine($"Tries left: {counted - x}");
                    if (x == 4) {
                        System.Console.WriteLine($"Sorry. The correct answer was {guesser}. Better luck next time.");
                    }
                }
            }
            
            // exercise 5
            System.Console.WriteLine("Enter a series of numbers separated by a comma:");
            string series = Console.ReadLine() ?? " ";
            string[] digs = series.Split(',');
            int[] nums = new int[digs.Length];
            int count = 0;
            foreach(string dig in digs) {
                nums[count] = Int32.Parse(dig);
                count++;
            }
            System.Console.WriteLine(nums.Max());
        }
    }
}
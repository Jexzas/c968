using System;

namespace arrays {
    public class Arrayed { 
        public static void Main() {
            // rectangular
            var matrix = new int[3,5];
            // jagged
            var notMatrix = new int[3][];

            int[] ints = [1,2,3,4,5,6,7];
            int[] copy = new int[3];
            Array.Copy(ints, copy, 3);
            

            // Lists?
            var numbums = new List<int>();
            for (int i = 0; i < 150; i++) {
                if (i % 7 == 0) {
                    numbums.Add(i);
                }
            }
            for (int i = 0; i < 1500; i++) {
                if (i % 114 == 0) {
                    numbums.Add(i);
                }
            }
            foreach(int i in numbums) {
                System.Console.WriteLine(i);
            }
            System.Console.WriteLine($"Last index: {numbums[^1]} - {numbums.LastIndexOf(numbums[^1])}");

            // Exercise 1
            var friends = new List<string> ();
            string resp = "";
            System.Console.WriteLine("Who liked your post? Enter one name at a time, and 'ok' if you're done:");
            while (resp != "ok") {
                resp = System.Console.ReadLine() ?? "ok";
                if (resp != "ok") {
                    friends.Add(resp);
                }
            }
            switch (friends.Count) {
                case 0:
                    System.Console.WriteLine("No one liked your post.");
                    break;
                case 1: 
                    System.Console.WriteLine($"{friends[0]} liked your post.");
                    break;
                case 2:
                    System.Console.WriteLine($"{friends[0]} and {friends[1]} liked your post.");
                    break;
                default:
                    System.Console.WriteLine($"{friends[0]}, {friends[1]}, and {friends.Count - 2} others liked your post.");
                    break;
            }

            // Exercise 2
            System.Console.WriteLine("For some reason, we want your name backwards. Please enter it:");
            string name = Console.ReadLine() ?? "null";
            char[] nameArray = name.ToCharArray(); 
            Array.Reverse(nameArray);
            string backwurd = String.Join("", nameArray);
            System.Console.WriteLine(backwurd);

            // Exercise 3
            System.Console.WriteLine("We're going to need five numbers. Press enter after each number:");
            int[] booper = {1, 4, 5, 5, 3};
            int[] usNum = new int[5];
            int thisCount = 0;
            while(thisCount < booper.Length) {
                int thisNum = Int32.Parse(Console.ReadLine() ?? "0");
                if (Array.IndexOf(usNum, thisNum) == -1) {
                    usNum[thisCount] = thisNum;
                    thisCount++;
                } else {
                    System.Console.WriteLine("That number has already been entered. Please try again:");
                }
            }
            Array.Sort(usNum);
            System.Console.WriteLine(
                $"The numbers you entered are: {String.Join(", ", usNum)}"
            );  

            // Exercise 4
            // not doing this one because it's the same solution as 3

            // Exercise 5
            string usNum2;
            System.Console.WriteLine("Enter a list of numbers, separated by comma. We need at least five: ");
            usNum2 = Console.ReadLine() ?? ""; 
            char[] chars2 = usNum2.ToCharArray();
            if (chars2.Length >= 5) {
                int[] ints2 = usNum2.Split(',')
                    .Select(Int32.Parse)
                    .ToArray();
                Array.Sort(ints2);
                System.Console.WriteLine($"The smallest three digits are: {ints2[0]}, {ints2[1]}, {ints2[2]}");
            } else {
                System.Console.WriteLine("You didn't enter enough numbers. Sorry.");
            }
        }        
    }
}
using System;

namespace Loop {
    public class Loop {
        public static void Main(String[] args) {
            int[] numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]; 
            List<double> list = new List<double>{};
            int count = 0;
            foreach (int i in numbers) {
                Console.WriteLine(i * i);
                numbers[count] = i * i;
                list.Add(numbers[count]*i);
                count++;
            }
            foreach (int i in list) {
                System.Console.WriteLine(i);
            }
            // this will never run
            while (count < 8) {
                System.Console.WriteLine("whoa");
            }
            // this will run once
            do {
                Console.WriteLine("whoa2");
            } while (count < 8);
            // ay yo paulie we got any randos?
            // is Next inclusive? yes
            // strong password generator?
            var random = new Random();
            char[] letters = new char[20];
            for (var i = 0; i < 20; i++) {
                if (random.Next(1, 7) == 3) {
                    letters[i] = (char)random.Next(91, 96);
                } else if (random.Next(1, 7) < 3) {
                    letters[i] = (char)random.Next(65, 90);
                } else if (random.Next(1,7) == 5) {
                    letters[i] = (char)random.Next(48, 57);
                }  else {
                    letters[i] = (char)random.Next(97, 122);
                }
            }
            var password = new string(letters);
            System.Console.WriteLine(password);
        }
    }
}
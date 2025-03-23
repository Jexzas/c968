using System;

namespace Text {
    public class Text {
        public static void Main() {
            
            string myString = " binkle tingle tiknkle donknle an ";

            System.Console.WriteLine(myString.Trim());
            System.Console.WriteLine(myString.Replace("b", "#"));
            string[] vars= myString.Split(" ");
            foreach(string var in vars) {
                System.Console.WriteLine(var);
            }

            int bnbb = 1235135;
            System.Console.WriteLine(bnbb.ToString("C"));
            const int maxLength = 200;
            string text = "Max, a scruffy golden retriever, had one job—guard the house. But he loved people too much. One night, a burglar crept through the window. Max wagged his tail, thrilled for the late-night visitor. He licked the man’s hand, nudging a tennis ball toward him. The burglar, startled, tripped over Max’s toy, crashing into a table. The noise woke the owners, who called the police. As the officers hauled the thief away, Max proudly sat with his tail thumping. He might not have been fierce, but he was the best guard dog in town—just in his own way.";
            if (text.Length < maxLength) {
                Console.WriteLine(text);
            } else {
                System.Console.WriteLine("That string is " + text.Length + " characters long. That's far too many.");
                string newText = text.Substring(0, maxLength) + "...";
                Console.WriteLine(newText);
                System.Console.WriteLine("If you'd like to see the full text, type 'ok'");
                if (Console.ReadLine() == "ok") {
                    System.Console.WriteLine(text);
                }
            }

            // Exercise 1
            System.Console.WriteLine("Enter a series of numbers separated by hypen:");
            string usrPut = Console.ReadLine() ?? " ";
            string[] putput = usrPut.Split("-");
            int[] inted = new int[putput.Length];
            int countered = 0;
            foreach (string put in putput) {
                inted[countered] = Int32.Parse(put);
                countered++;
            }
            bool cons = false;
            for(int i = 1; i < inted.Length; i++) {
                if (inted[i] > inted[i - 1]) {
                    cons = true;
                } else {
                    cons = false;
                    break;
                }
            }
            if (cons) {
                Console.WriteLine("This series is consecutive.");
            } else {
                System.Console.WriteLine("This series is not sorted.");
            }
            

            // Exercise 2
            bool done = false;
            while (!done) {
                System.Console.WriteLine("Enter a series of numbers separated by hyphen:");
                string newGuy = Console.ReadLine() ?? "";
                if (String.IsNullOrEmpty(newGuy)) {
                    done = true;
                } else {
                    string[] aray = newGuy.Split("-");
                    int[] arayed = new int[aray.Length];
                    int coun = 0;
                    foreach(string x in aray) {
                        if (Array.IndexOf(arayed, Int32.Parse(x)) != -1) {
                            System.Console.WriteLine("Duplicate found");
                            done = true;
                            break;
                        }
                        arayed[coun] = Int32.Parse(x);
                        coun++;
                    }
                }
            }

            // Exercise 3
            System.Console.WriteLine("Please enter a time in 24-hour format (ex: 19:24):");
            try {
                string usrDate = Console.ReadLine() ?? "0";
                var theDate = DateTime.Parse(usrDate);
                System.Console.WriteLine($"{theDate.Hour}:{theDate.Minute}");
            } catch(Exception e) {
                System.Console.WriteLine("Invalid time." + e.Message);
            }
            
            
            // Exercise 4
            System.Console.WriteLine("Enter a string with multiple words separated by spaces:");
            string usrString = Console.ReadLine() ?? "";
            var newString = "";
            if (usrString.Length > 0) {
                string[] yup = usrString.Split(" ");
                for(int y = 0; y < yup.Length; y++) {
                    yup[y] = yup[y].ToLower();
                    char[] temp = yup[y].ToCharArray();
                    temp[0] = Char.ToUpper(temp[0]);
                    yup[y] = String.Join("", temp);
                }
                newString = String.Join("", yup);
            }
            System.Console.WriteLine(newString);
            

            // Exercise 5
            System.Console.WriteLine("Enter a word that uses the Latin script (english, french, latin, italian, spanish, et cetera):");
            string voweled = Console.ReadLine() ?? "";
            if (voweled == "") {
                Console.WriteLine("No.... Enter something next time.");
            } else {
                char[] chars = voweled.ToCharArray();
                int vount = 0;
                foreach (char c in chars) {
                    if (char.ToLower(c) == 'a' || char.ToLower(c) == 'e' || char.ToLower(c) == 'i' || char.ToLower(c) == 'o' || char.ToLower(c) == 'u') {
                        vount++;
                    }
                }
                Console.WriteLine($"There are {vount} vowels in that word.");
            }
        }
    }
}
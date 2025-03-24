using System.IO;
using System.Linq;

namespace Files {
    public class Files {
        public static void Main() {
            // file and fileinfo are for opening and whatnot with files
            // file is static, fileinfo is instance
            // create, copy, delete, exists, getattributes move, readalltext
            // directory and directoryinfo are same for dirs
            // createdirectory, delete, exists, getcurrentdirectory, getfiles,move, getlogicaldrives
            // path
            // getdirectoryname, getfilename, getextension, gettemppath


            // demo
            // var myFile = new FileInfo("./files.csproj");
            // Console.WriteLine(File.ReadAllText(myFile.FullName));
            // Directory.CreateDirectory("./whobe");
            // var stuff = Directory.GetFiles("./");
            // foreach (var file in stuff) {
            //     System.Console.WriteLine(file);
            // }

            // string pathed = @"D:\";
            // string[] moreStuff = Directory.GetFiles(pathed);            
            // foreach(var thing in moreStuff) {
            //     System.Console.WriteLine(String.IsNullOrEmpty(Path.GetExtension(thing)) ? "No extension" : Path.GetExtension(thing) );
            // }

            // Exercise 1
            // Read text file, give word count
            var file = new FileInfo("./sample.txt");
            System.Console.WriteLine(File.ReadAllText(file.FullName));
            string theStory = File.ReadAllText(file.FullName).Trim();
            static string storyConv(string theStory) {
                string s1 = theStory.Replace(",", " ");
                string s2 = s1.Replace(".", " ");
                string s3 = s2.Replace("\\", " ");
                string s4 = s3.Replace("-", " ");
                string s5 = s4.Replace("?", " ");
                string s6 = s5.Replace("\"", " ");
                return s6;
            }
            string fixStory = storyConv(theStory);
            string[] arrayed = fixStory.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in arrayed) {
                System.Console.WriteLine(word);
            }
            System.Console.WriteLine($"That story contains {arrayed.Length} words.");
            var sorted = arrayed.OrderBy(word => word.Length).ToArray();
            System.Console.WriteLine("The longest word is " + sorted.Last());
        }
    }
}
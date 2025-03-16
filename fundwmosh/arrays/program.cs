using System;

namespace Array {
    public class Array {
        public static void Main () {
            int[] stuff = new int[500];
            for (int i = 0; i < 500; i++) {
                stuff[i] = i;
            }
            foreach(int i in stuff) {
                System.Console.WriteLine(stuff[i]);
            }
        }
    }
}
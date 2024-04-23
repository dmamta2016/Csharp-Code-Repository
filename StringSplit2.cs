using System;

public class StringSplit2 {
    public static void Main() {

        string delimStr = " ,.:";
    char [] delimiter = delimStr.ToCharArray();
        string words = "one two,three:four.";
        string [] split = null;

    Console.WriteLine("The delimiters are -{0}-", delimStr);
    for (int x = 1; x <= 5; x++) {
        split = words.Split(delimiter, x);
            Console.WriteLine("\ncount = {0,2} ..............", x);
        foreach (string s in split) {
                Console.WriteLine("-{0}-", s);
              }
    }
    }
}

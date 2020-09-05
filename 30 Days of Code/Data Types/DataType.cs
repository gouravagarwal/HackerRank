using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
    static void Main(String[] args)
    {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";


        // Declare second integer, double, and String variables.
        int secInt; double secDoub; string str;

        // Read and save an integer, double, and String to your variables.
        secInt = Convert.ToInt32(Console.ReadLine());
        secDoub = Convert.ToDouble(Console.ReadLine());
        str = Console.ReadLine();

        // Print the sum of both integer variables on a new line.
        Console.WriteLine(i + secInt);

        // Print the sum of the double variables on a new line.
        Console.WriteLine("{0:F1}", (d + secDoub));

        // Concatenate and print the String variables on a new line
        // The 's' variable above should be printed first.
        Console.WriteLine(s + str);

    }
}
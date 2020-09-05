using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int T = int.Parse(Console.In.ReadLine());

        for (int j = 0; j < T; j++)
        {
            string str = Console.In.ReadLine();
            string a = "", b = "";

            int length = str.Length;
            if (length >= 2 && length <= 10000)
            {
                for (int i = 0; i < length; i++)
                {
                    if (i % 2 == 0)
                        a += str[i];
                    else
                        b += str[i];
                }

                Console.WriteLine("{0} {1}", a, b);
            }
        }
    }
}


namespace DATASTRUCTURES.LeetCode_August2020
{
	using System;
	using System.Collections.Generic;
	using System.Text;

    public static class FizzBuzz
    {
        public static void PrintFizzBuzzWithModulo()
        {
            for (int i=1; i<=100; i++)
            {
                var d = string.Empty;
                if (i % 3 == 0)
                {
                   d += "Fizz";
                }
                if (i % 5 == 0)
                {
                    d += "Buzz";
                }
                if (d.Length == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(d);
                }
            }
        }

        public static void PrintFizzBuzzWithoutModulo()
        {
            int c3 = 0;
            int c5 = 0;
            for (int i = 1; i <= 100; i++)
            {
                c3++;
                c5++;
                var d = string.Empty;
                if (c3 == 3)
                {
                    d += "Fizz";
                    c3 = 0;
                }
                if (c5 == 5)
                {
                    d += "Buzz";
                    c5 = 0;
                }
                if (d == string.Empty)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(d);
                }
            }
        }
    }
}

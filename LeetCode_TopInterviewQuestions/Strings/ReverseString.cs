namespace DATASTRUCTURES.LeetCode_TopInterviewQuestions.Strings
{
    using System;
    public class ReverseString
    {
        public static void Reverse(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            string reverseString = new string(charArray);
            Console.WriteLine(reverseString);
        }

        private static void PrintReverseNumber()
        {
            System.Console.WriteLine("Enter the number:");
            int nextNum = Convert.ToInt32(Console.ReadLine());
            PrintReverseNumber();
            Console.WriteLine(nextNum);
        }
        public static void ReverseNumberRecursive()
        {
            System.Console.WriteLine("Enter the length:");
            int len = Convert.ToInt32(Console.ReadLine());
            for(int i=0; i<len; i++){
                PrintReverseNumber();
            }
        }
    }
}
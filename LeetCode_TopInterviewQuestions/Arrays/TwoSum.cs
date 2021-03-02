namespace DATASTRUCTURES.LeetCode_TopInterviewQuestions.Arrays
{
    using System;
    using System.Collections.Generic;

    public class TwoSum
    {
        private int[] GetTheTwoSumPair(int[] array, int twoSum)
        {
            Dictionary<int, int> ComplementItems = new Dictionary<int, int>();
            for(int index=0; index<array.Length; index++)
            {
                if(ComplementItems.ContainsKey(array[index]))
                {                 
                    return new int[] {ComplementItems[array[index]], index};
                }
                else
                {
                    ComplementItems.Add(twoSum - array[index], index);
                }
            }

            return null;
        }
        public static void MainMethod()
        {
            int[] array = new int[] { 2,7,11,15 };
            int sum = 9;
            TwoSum obj = new TwoSum();
            int[] res = obj.GetTheTwoSumPair(array, sum);
            Console.WriteLine(res);
        }
    }
}
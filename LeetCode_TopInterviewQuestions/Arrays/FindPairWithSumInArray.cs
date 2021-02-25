namespace DATASTRUCTURES.LeetCode_TopInterviewQuestions.Arrays
{
    using System;
    using System.Collections.Generic;

    public class FindPairWithSumInArray
    {
        private bool HasPairWithSumInSortedArray(int[] array, int sum)
        {
            int start = 0;
            int end = array.Length-1;

            while(start < end)
            {
                int tempSum = array[start] + array[end];
                if(tempSum == sum)
                {
                    return true;
                }

                if(tempSum < sum)
                {
                    start++;
                }
                else
                {
                    end--;
                }
            }

            return false;
        }

        private bool HasPairWithSumInUnSortedArray(int[] array, int sum)
        {
            HashSet<int> Complements = new HashSet<int>();

            foreach(var item in array)
            {
                if(Complements.Contains(item))
                {
                    return true;
                }
                else
                {
                    Complements.Add(sum - item);
                }
            }

            return false;
        }
        public static void MainMethod()
        {
            int[] sortedArray = new int[] { 3, 4, 5, 6 };
            int[] unSortedArray = new int[] { 6, 4, 10, 9, 5, 7, 3, 2 };
            int sum = 8;
            FindPairWithSumInArray findPairWithSumInArray = new FindPairWithSumInArray();
            //bool found = findPairWithSumInArray.HasPairWithSumInSortedArray(sortedArray, sum);
            bool found = findPairWithSumInArray.HasPairWithSumInUnSortedArray(unSortedArray, sum);
            Console.WriteLine(found);
        }
    }
}
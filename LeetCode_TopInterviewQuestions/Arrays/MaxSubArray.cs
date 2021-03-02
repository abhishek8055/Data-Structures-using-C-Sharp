namespace DATASTRUCTURES.LeetCode_TopInterviewQuestions.Arrays
{
    using System;
    using System.Collections.Generic;

    public class MaxSubArray
    {
        private int FindMaxSubArray(int[] nums) 
        {
            int sum = nums[0];
            int result = sum;

            for(int index=1; index<nums.Length; index++)
            {
                sum = Math.Max(nums[index], nums[index] + sum);
                result = Math.Max(result, sum);
            }

            return result;
        }
        public static void MainMethod()
        {
            int[] array = new int[] { -2,1,-3,4,-1,2,1,-5,4 };
            MaxSubArray obj = new MaxSubArray();
            int res = obj.FindMaxSubArray(array);
            Console.WriteLine(res);
        }
    }
}
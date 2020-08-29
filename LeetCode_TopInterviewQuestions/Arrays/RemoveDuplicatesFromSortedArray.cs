using System;
using System.Linq;
namespace DATASTRUCTURES.LeetCode_TopInterviewQuestions.Arrays
{
    public class RemoveDuplicatesFromSortedArray
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;
            int uniqueFlag = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                int current = i;
                int prev = current - 1;
                while (nums[current] == nums[prev])
                {
                    if (current >= nums.Length - 1) break;
                    current++;
                }
                if (nums[prev] < nums[current])
                {
                    for (int j = prev + 1; j <= current - 1; j++)
                        nums[j] = nums[current];
                    ++uniqueFlag;
                }
                if (current >= nums.Length - 1) break;
            }
            nums = nums.Take(uniqueFlag + 1).ToArray();
            return nums.Length;
        }
        public static void MainMethod()
        {
            int[] nums = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            RemoveDuplicatesFromSortedArray obj = new RemoveDuplicatesFromSortedArray();
            int x = obj.RemoveDuplicates(nums);
        }
    }
}
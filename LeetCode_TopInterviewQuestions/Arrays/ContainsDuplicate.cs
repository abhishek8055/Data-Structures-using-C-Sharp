using System.Collections.Generic;
using System.Linq;

namespace DATASTRUCTURES.LeetCode_TopInterviewQuestions.Arrays
{
    public class ContainsDuplicate
    {
        public bool containsDuplicate1(int[] nums) {
            System.Array.Sort(nums);
            for(int i=0; i<nums.Length-1; i++){
                if(nums[i] == nums[i+1])
                    return true;
            }
            return false;
        }

        public bool containsDuplicate2(int[] nums) {
            HashSet<int> set = new HashSet<int>();
            foreach(int item in nums){
                if(set.Contains(item))
                    return true;
                set.Add(item);
            }
            return false;
        }

        public static void MainMethod(){
            int[] nums = new int[] { 4,2,3,1 };
            ContainsDuplicate obj = new ContainsDuplicate();
            bool result = obj.containsDuplicate2(nums);
        }
    }
}
namespace DATASTRUCTURES.LeetCode_TopInterviewQuestions.Arrays
{
    using System;
    using System.Collections.Generic;

    public class MoveZeros
    {
        public void Move_Zeroes(int[] nums) 
        {          
            for(int index=0; index<nums.Length-1; index++)
            {
                if(nums[index] == 0){
                    int nextNonZeroIndex = index+1;
                    while(nums[nextNonZeroIndex] == 0){
                        if(nextNonZeroIndex >= nums.Length-1){
                            break;
                        }
                        nextNonZeroIndex++;
                    }
                    if(nums[nextNonZeroIndex] != 0){
                         nums[index] = nums[nextNonZeroIndex];
                        nums[nextNonZeroIndex] = 0;
                    }                
                }               
            }
        }

        public void Move_Zeroes2(int[] nums) 
        {  
            int nonZeroIndex = 0;
            int[] copy = new int[nums.Length];
            foreach(int item in nums){
                if(item != 0){
                    copy[nonZeroIndex] = item;
                    nonZeroIndex++;
                }
            }   
      
            for(int index=0; index<copy.Length; index++){
                nums[index] = copy[index];
            }
        }
        public static void MainMethod()
        {
            int[] array = new int[] { 0,1,0,3,12 };
            MoveZeros obj = new MoveZeros();
            obj.Move_Zeroes(array);
            foreach(int item in array){
                Console.Write(item + " ");
            }
        }
    }
}
namespace DATASTRUCTURES.LeetCode_TopInterviewQuestions.Arrays
{
    public class RotateArray
    {
        public void Rotate(int[] nums, int k) 
        {
            k = k % nums.Length;
            ReverseArray(nums, 0, nums.Length-1);  
            ReverseArray(nums, 0, k-1);  
            ReverseArray(nums, k, nums.Length-1);         
        }

        public static void ReverseArray(int[] nums, int start, int end)
        {
            while(start < end){
                int temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;
                start++;
                end--;
            }
        }

        public static void MainMethod()
        {
            int[] nums = new int[] { 1,2,3,4 };
            RotateArray obj = new RotateArray();
            obj.Rotate(nums, 2);
        }
    }
}
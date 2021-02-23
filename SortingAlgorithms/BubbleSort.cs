namespace DATASTRUCTURES.SortingAlgorithms
{
    using System;
    public class BubbleSort{
        private static void Swap(int[] arr, int i, int j){
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
        private void Sort(int[] arr){
            if(arr.Length > 0){
                for(int i=0; i<arr.Length-1; i++){
                    for(int j=i+1; j<arr.Length; j++){
                        if(arr[i] > arr[j]){
                            Swap(arr, i, j);
                        }
                    }
                }
            }
        }
        public static void MainMethod(){
            
            int[] nums = {50, 23, 9, 18, 61, 32};
            BubbleSort obj = new BubbleSort();
            obj.Sort(nums);
            Console.WriteLine("Sorted Array:");
            for(int i=0; i<nums.Length; i++)
                Console.WriteLine(nums[i]);
        }
    }
}
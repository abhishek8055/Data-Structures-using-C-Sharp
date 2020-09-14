using System;

namespace DATASTRUCTURES.SortingAlgorithms
{
    // DIVIDE AND CONQUER SORTING ALGORITHM (MERGE & QUICK)
    // TIME COMPLEXITY
    //      BEST & AVERAGE CASE - O(NLOGN)
    //      WORST CASE - O(N2)
    //      1. BEST CASE: EACH TIME PIVOT ELEMENT COMES AT THE MIDDLE DIVIDING ARRAY IN TWO PARTITIONS-
    //            I. P1 : ALL ELEMENTS SMALLER THAN PIVOT
    //            II. P2 : ALL ELEMENTS GREATER THAN PIVOT
    //      2. AVERAGE CASE: RANDOM ARRAY
    //      3. WORST CASE: ALREADY SORTED ARRAY
    // 
    // SPACE COMPLEXITY
    //      O(1) - SINCE QUICKSORT USES IN-PLACE SHIFTING OF ELEMENTS.
    public class QuickSort
    {
        public static void Swap(int[] arr, int i, int j){
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
        public static int Partition(int[] arr, int start, int end){
            int pivot = arr[end];
            int index = start-1;

            for(int i=start; i<end; i++){
                if(arr[i] < pivot){
                    index++;
                    Swap(arr, i, index);
                }
            }
            index++;
            Swap(arr, index, end);
            return index;
        }

        public void Sort(int[] arr, int start, int end){
            if(start < end){
                int pivot = Partition(arr, start, end);
                Sort(arr, start, pivot-1);
                Sort(arr, pivot+1, end);
            }
        }

        public static void MainMethod(){
            
            int[] nums = {50, 23, 9, 18, 61, 32};
            QuickSort obj = new QuickSort();
            obj.Sort(nums, 0, nums.Length-1);
            Console.WriteLine("Sorted Array:");
            for(int i=0; i<nums.Length; i++)
                Console.WriteLine(nums[i]);
        }
    }
}
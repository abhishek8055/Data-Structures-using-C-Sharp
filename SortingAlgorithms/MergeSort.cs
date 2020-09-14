using System;

namespace DATASTRUCTURES.SortingAlgorithms
{
    public class MergeSort
    {
        // DIVIDE AND CONQUER SORTING ALGORITHM (MERGE & QUICK)
        // 
        // TIME COMPLEXITY
        //      BEST, AVERAGE & AVERAGE CASE - O(NLOGN)
        // 
        // SPACE COMPLEXITY
        //      O(N) - SINCE MERGESORT USES 2 SUB ARRAYS FOR COMPARISON DURING THE MERGE.
        //      O(LOGN) - BY USING LINKEDLIST IMPLEMENTATION.

        private static void Merge(int[] arr, int lb, int mid, int ub)
        {
            int n1 = mid - lb + 1;
            int n2 = ub - mid;
            int[] L = new int[n1];
            int[] R = new int[n2];

            for(int x=0; x<n1; x++)
                L[x] = arr[lb+x];
            for(int x=0; x<n2; x++)
                R[x] = arr[mid+1+x];

            int i=0, j=0;  
            int k=lb; 
            while(i<n1 && j<n2){
                if(L[i] < R[j]){
                    arr[k] = L[i];
                    i++;
                }
                else{
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }
            while(i<n1){
                arr[k] = L[i];
                i++;
                k++;
            }
             while(j<n2){
                arr[k] = R[j];
                j++;
                k++;
            }
        }
        private void Sort(int[] arr, int lb, int ub){
            if(lb < ub){
                int mid = (lb+ub)/2;
                Sort(arr, lb, mid);
                Sort(arr, mid+1, ub);
                Merge(arr, lb, mid, ub);
            }
        }

        public static void MainMethod(){
            
            int[] nums = {50, 23, 9, 18, 61, 32};
            MergeSort obj = new MergeSort();
            obj.Sort(nums, 0, nums.Length-1);
            Console.WriteLine("Sorted Array:");
            for(int i=0; i<nums.Length; i++)
                Console.WriteLine(nums[i]);
        }
    }
}
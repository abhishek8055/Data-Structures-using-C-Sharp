using DATASTRUCTURES.Trees;

namespace DATASTRUCTURES.LeetCode_August2020
{
    public class SumOfLeftLeaves
    {
        private static TreeOperations binaryTree = null;
        public SumOfLeftLeaves(int[] nodes)
        {
            binaryTree = new TreeOperations();
            binaryTree.BuildBinarySearchTree(nodes);
        }

        public int GetSumOfLeftLeaves()
        {
            return binaryTree.SumOfLeftLeaves(binaryTree.root);
        }

        public static void MainMethod()
        {
            int[] nodes = new int[] { 10, 8, 4, 9, 12, 11, 15 };
            SumOfLeftLeaves sumOfLeftLeaves = new SumOfLeftLeaves(nodes);
            int sum = sumOfLeftLeaves.GetSumOfLeftLeaves();
        }
    }
}
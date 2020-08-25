using System.Collections.Generic;
using System.Linq;
using DATASTRUCTURES.Common;

namespace DATASTRUCTURES.Trees
{
    public class TreeOperations : BinarySearchTree
    {
        public TreeOperations()
        {

        }
        public TreeOperations(int value) : base(value)
        {

        }

        public int SumOfLeftLeaves(TreeNode root)
        {
            int sum = 0;
            if (root == null) return 0;
            if (root.LeftNode != null)
            {
                if (root.LeftNode.LeftNode != null || root.LeftNode.RightNode != null)
                    sum += SumOfLeftLeaves(root.LeftNode);
                else
                    sum += root.LeftNode.Value;
            }
            if (root.RightNode != null)
                sum += SumOfLeftLeaves(root.RightNode);
            return sum;
        }

        public int SumOfLeftLeavesStack(TreeNode root)
        {
            int sum = 0;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            if (root == null) return 0;
            stack.Push(root);
            while (stack.Count > 0)
            {
                TreeNode currNode = stack.Pop();
                if (currNode.LeftNode != null)
                {
                    if (currNode.LeftNode.LeftNode == null && currNode.LeftNode.RightNode == null)
                        sum += currNode.LeftNode.Value;
                    else
                        stack.Push(currNode.LeftNode);
                }
                if (currNode.RightNode != null) stack.Push(currNode.RightNode);
            }
            return sum;
        }

        public void BuildBinarySearchTree(int[] nodes)
        {
            foreach (int val in nodes)
                InsertNode(val);
        }
    }
}
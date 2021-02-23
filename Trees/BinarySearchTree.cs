namespace DATASTRUCTURES.Trees
{
    using System;
    public class BinarySearchTree
    {
        public TreeNode root = null;

        public bool IsTreeInitialized = false;

        public BinarySearchTree()
        {
            root = new TreeNode();
        }
        public BinarySearchTree(int value)
        {
            root = new TreeNode(value);
            IsTreeInitialized = true;
        }
        public TreeNode InsertNode(int value)
        {
            TreeNode newNode = new TreeNode(value);
            if (!IsTreeInitialized)
            {
                root = newNode;
                IsTreeInitialized = true;
                return root;
            }
            TreeNode prevNode = null;
            TreeNode currNode = root;
            while (currNode != null)
            {
                prevNode = currNode;
                if (currNode.Value >= value)
                    currNode = currNode.LeftNode;
                else
                    currNode = currNode.RightNode;
            }
            if (prevNode.Value > value)
                prevNode.LeftNode = newNode;
            else
                prevNode.RightNode = newNode;
            return newNode;
        }

        public TreeNode SearchNode(int value)
        {
            if (root == null) throw new NotImplementedException("Tree is not implemented, there is no node in the tree.");
            TreeNode currNode = root;
            while (currNode != null)
            {
                if (currNode.Value == value)
                    return currNode;
                if (currNode.Value > value)
                    currNode = currNode.LeftNode;
                else if (currNode.Value < value)
                    currNode = currNode.RightNode;
            }
            return null;
        }

        public int GetBinarySearchTreeDepth(TreeNode root)
        {
            if (root == null)
                return 0;
            else
                return 1 + Math.Max(GetBinarySearchTreeDepth(root.LeftNode), GetBinarySearchTreeDepth(root.RightNode));
        }
    }
}
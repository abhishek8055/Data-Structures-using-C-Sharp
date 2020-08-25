using System;

namespace DATASTRUCTURES.Common
{
    public class TreeNode
    {
        private int _value;
        private TreeNode _leftNode;
        private TreeNode _rightNode;

        public TreeNode RightNode
        {
            get { return this._rightNode; }
            set { this._rightNode = value; }
        }

        public TreeNode LeftNode
        {
            get { return this._leftNode; }
            set { this._leftNode = value; }
        }

        public int Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        public TreeNode()
        {

        }

        /// <summary>initializes node object using constructor.</summary>
        /// <param name="val"> the data value stored in a node</param>
        /// <returns> return Node instance with Value set to val passed, left and right references set to null.</returns>
        public TreeNode(int val)
        {
            this.Value = val;
            this.RightNode = null;
            this.LeftNode = null;
        }
    }
}
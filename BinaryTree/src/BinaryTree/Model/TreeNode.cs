using System;

namespace BinaryTree
{
    public class TreeNode<T> where T : IComparable
    {
        public TreeNode<T> ParentNode { get; set; }

        private TreeNode<T> _leftNode;
        public TreeNode<T> LeftNode
        {
            get { return _leftNode; }
            set
            {
                if (value != null)
                    value.ParentNode = this;
                _leftNode = value;
            }
        }

        private TreeNode<T> _rightNode;
        public TreeNode<T> RightNode
        {
            get { return _rightNode; }
            set
            {
                if (value != null)
                    value.ParentNode = this;
                _rightNode = value;
            }
        }

        public T Value { get; set; }
        public bool IsRed { get; set; }

    }
}
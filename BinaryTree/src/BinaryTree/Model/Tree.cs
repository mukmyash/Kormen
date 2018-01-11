using System;

namespace BinaryTree
{
    public class Tree<T> where T : IComparable
    {
        public TreeNode<T> Root { get; set; }


        public void Insert(T value)
        {
            Insert(Root, value);
        }

        public void Insert(TreeNode<T> tree, T value)
        {
            TreeNode<T> y = null;
            TreeNode<T> x = Root;
            while (x != null)
            {
                y = x;
                if (value.CompareTo(x.Value) < 0)
                    x = x.LeftNode;
                else
                    x = x.RightNode;
            }
            if (y == null)
                Root = new TreeNode<T>() { Value = value };
            else
            {
                if (value.CompareTo(y.Value) < 0)
                    y.LeftNode = new TreeNode<T>() { Value = value };
                else
                    y.RightNode = new TreeNode<T>() { Value = value };
            }
        }

        public TreeNode<T> Search(T value)
        {
            return Search(Root, value);
        }

        private TreeNode<T> Search(TreeNode<T> tree, T value)
        {
            if (tree == null || tree.Value.Equals(value))
                return tree;
            if (value.CompareTo(tree.Value) < 0)
                return Search(tree.LeftNode, value);
            else
                return Search(tree.RightNode, value);
        }

        public void Delete(T value)
        {
            Delete(Root, Search(value));
        }
        public void Delete(TreeNode<T> tree, TreeNode<T> deleteNode)
        {
            if (deleteNode.LeftNode == null)
                Transplant(tree, deleteNode, deleteNode.RightNode);
            else
            {
                if (deleteNode.RightNode == null)
                    Transplant(tree, deleteNode, deleteNode.LeftNode);
                else
                {
                    var minRight = GetMinimum(deleteNode.RightNode);
                    if (minRight.ParentNode != deleteNode)
                    {
                        Transplant(tree, minRight, minRight.RightNode);
                        minRight.RightNode = deleteNode.RightNode;
                    }
                    Transplant(tree, deleteNode, minRight);
                    minRight.LeftNode = deleteNode.LeftNode;
                }
            }
        }

        private void Transplant(TreeNode<T> tree, TreeNode<T> delNode, TreeNode<T> upNode)
        {
            if (delNode.ParentNode == null){
                Root = upNode;
                upNode.ParentNode = null;
            }
            else
            {
                if (delNode == delNode.ParentNode.LeftNode)
                    delNode.ParentNode.LeftNode = upNode;
                else
                    delNode.ParentNode.RightNode = upNode;
            }
            // if (upNode != null)
            //     upNode.ParentNode = delNode.ParentNode;
        }


        public TreeNode<T> GetMinimum()
        {
            return GetMinimum(Root);
        }
        public TreeNode<T> GetMinimum(TreeNode<T> tree)
        {
            while (tree.LeftNode != null)
            {
                tree = tree.LeftNode;
            }
            return tree;
        }
        public TreeNode<T> GetMaximum()
        {
            return GetMaximum(Root);
        }
        public TreeNode<T> GetMaximum(TreeNode<T> tree)
        {
            while (tree.RightNode != null)
            {
                tree = tree.RightNode;
            }
            return tree;
        }

        public void RightRotation(T value)
        {
            RightRotation(Search(value));
        }
        public void RightRotation(TreeNode<T> node)
        {
            var y = node.LeftNode;
            node.LeftNode = y.RightNode;

            if (node.ParentNode == null)
            {
                y.ParentNode = node.ParentNode;
                Root = y;
            }
            else
            {
                if (node == node.ParentNode.LeftNode)
                    node.ParentNode.LeftNode = y;
                else
                    node.ParentNode.RightNode = y;
            }
            y.RightNode = node;
        }

        public void LeftRotation(T value)
        {
            LeftRotation(Search(value));
        }

        public void LeftRotation(TreeNode<T> node)
        {
            var y = node.RightNode;
            node.RightNode = y.LeftNode;

            if (node.ParentNode == null)
            {
                y.ParentNode = node.ParentNode;
                Root = y;
            }
            else
            {
                if (node == node.ParentNode.LeftNode)
                    node.ParentNode.LeftNode = y;
                else
                    node.ParentNode.RightNode = y;
            }
            y.LeftNode = node;
        }
    }
}
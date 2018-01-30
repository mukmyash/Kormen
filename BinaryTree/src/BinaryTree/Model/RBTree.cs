using System;

namespace BinaryTree
{
    public class RBTree<T> : Tree<T> where T : IComparable
    {
        public new void Insert(T value)
        {
            Insert(Root, value);
        }
        public new void Insert(TreeNode<T> tree, T value)
        {
            TreeNode<T> insertNode = new TreeNode<T>() { Value = value };
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
                Root = insertNode;
            else
            {
                if (value.CompareTo(y.Value) < 0)
                    y.LeftNode = insertNode;
                else
                    y.RightNode = insertNode;
            }
            insertNode.IsRed = true;
            RBInsertFixup(tree, insertNode);
        }

        private void RBInsertFixup(TreeNode<T> tree, TreeNode<T> insertNode)
        {
            while (insertNode.ParentNode != null && insertNode.ParentNode.IsRed)
            {
                if (insertNode.ParentNode == insertNode.ParentNode.ParentNode.LeftNode)
                {
                    var y = insertNode.ParentNode.ParentNode.RightNode;
                    if (y != null && y.IsRed)
                    {
                        insertNode.ParentNode.IsRed = false;
                        y.IsRed = false;
                        insertNode.ParentNode.ParentNode.IsRed = true;
                        insertNode = insertNode.ParentNode.ParentNode;
                    }
                    else
                    {
                        if (insertNode == insertNode.ParentNode.RightNode)
                        {
                            insertNode = insertNode.ParentNode;
                            LeftRotation(insertNode);
                        }
                        insertNode.ParentNode.IsRed = false;
                        insertNode.ParentNode.ParentNode.IsRed = true;
                        RightRotation(insertNode.ParentNode.ParentNode);
                    }
                }
                else
                {
                    var y = insertNode.ParentNode.ParentNode.LeftNode;
                    if (y != null && y.IsRed)
                    {
                        insertNode.ParentNode.IsRed = false;
                        y.IsRed = false;
                        insertNode.ParentNode.ParentNode.IsRed = true;
                        insertNode = insertNode.ParentNode.ParentNode;
                    }
                    else
                    {
                        if (insertNode == insertNode.ParentNode.LeftNode)
                        {
                            insertNode = insertNode.ParentNode;
                            RightRotation(insertNode);
                        }
                        insertNode.ParentNode.IsRed = false;
                        insertNode.ParentNode.ParentNode.IsRed = true;
                        LeftRotation(insertNode.ParentNode.ParentNode);
                    }
                }
            }
            this.Root.IsRed = false;
        }

        public new void Delete(T value)
        {
            Delete(Root, Search(value));
        }
        public new void Delete(TreeNode<T> tree, TreeNode<T> deleteNode)
        {
            var y = deleteNode;
            var deleteNode_color = deleteNode.IsRed;
            TreeNode<T> x = null;
            if (deleteNode.LeftNode == null)
            {
                x = deleteNode.RightNode;
                Transplant(tree, deleteNode, deleteNode.RightNode);
            }
            else if (deleteNode.RightNode == null)
            {
                x = deleteNode.LeftNode;
                Transplant(tree, deleteNode, deleteNode.LeftNode);
            }
            else
            {
                y = GetMinimum(x.RightNode);
                deleteNode_color = y.IsRed;
                x = y.RightNode;
                if (y.ParentNode == deleteNode)
                    x.ParentNode = y;
                else
                {
                    Transplant(tree, y, y.RightNode);
                    y.RightNode = deleteNode.RightNode;
                    //y.RightNode.ParentNode = y;
                }
                Transplant(tree, deleteNode, y);
                y.LeftNode = deleteNode.LeftNode;
                //y.LeftNode.ParentNode = y;
                y.IsRed = deleteNode.IsRed;
            }
            if (!deleteNode_color)
            {
                RBDeleteFixup(tree, x);
            }
        }
        private void RBDeleteFixup(TreeNode<T> tree, TreeNode<T> deleteNode)
        {
            while (deleteNode != Root && !deleteNode.IsRed)
            {
                TreeNode<T> w = null;
                if (deleteNode == deleteNode.ParentNode.RightNode)
                {
                    w = deleteNode.ParentNode.RightNode;
                    if (w.IsRed)
                    {
                        w.IsRed = false;
                        deleteNode.ParentNode.IsRed = true;
                        LeftRotation(deleteNode.ParentNode);
                        w = deleteNode.ParentNode.RightNode;
                    }

                    if (!w.LeftNode.IsRed && !w.RightNode.IsRed)
                    {
                        w.IsRed = true;
                        deleteNode = deleteNode.ParentNode;
                    }
                    else
                    {
                        if (!w.RightNode.IsRed)
                        {
                            w.LeftNode.IsRed = false;
                            w.IsRed = true;
                            RightRotation(w);
                            w = deleteNode.ParentNode.RightNode;
                        }
                        w.IsRed = deleteNode.ParentNode.IsRed;
                        deleteNode.ParentNode.IsRed = false;
                        w.RightNode.IsRed = false;
                        LeftRotation(deleteNode.ParentNode);
                        deleteNode = Root;
                    }
                }
                else
                {
                    w = deleteNode.ParentNode.LeftNode;
                    if (w.IsRed)
                    {
                        w.IsRed = false;
                        deleteNode.ParentNode.IsRed = true;
                        LeftRotation(deleteNode.ParentNode);
                        w = deleteNode.ParentNode.LeftNode;
                    }

                    if (!w.RightNode.IsRed && !w.LeftNode.IsRed)
                    {
                        w.IsRed = true;
                        deleteNode = deleteNode.ParentNode;
                    }
                    else
                    {
                        if (!w.LeftNode.IsRed)
                        {
                            w.RightNode.IsRed = false;
                            w.IsRed = true;
                            RightRotation(w);
                            w = deleteNode.ParentNode.LeftNode;
                        }
                        w.IsRed = deleteNode.ParentNode.IsRed;
                        deleteNode.ParentNode.IsRed = false;
                        w.LeftNode.IsRed = false;
                        LeftRotation(deleteNode.ParentNode);
                        deleteNode = Root;
                    }
                }
            }
        }

        protected new void Transplant(TreeNode<T> tree, TreeNode<T> delNode, TreeNode<T> upNode)
        {
            if (delNode.ParentNode == null)
            {
                Root = upNode;
            }
            else if (delNode == delNode.ParentNode.LeftNode)
            {
                delNode.ParentNode.LeftNode = upNode;
            }
            else
            {
                delNode.ParentNode.RightNode = upNode;
            }
            //upNode.ParentNode = delNode.ParentNode;
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountriesAssignment
{
    class AVLTree<T> : BSTree<T> where T : IComparable
    {
        public new void InsertItem(T item)
        {
            if (!Contains(item)) //Check item isn't already there before inserting
            {
                InsertItem(item, ref root);
            }
        }

        private void InsertItem(T item, ref Node<T> tree)
        {
            if (tree == null)
            {
                tree = new Node<T>(item);
            }
            else if (item.CompareTo(tree.Data) < 0)
            {
                InsertItem(item, ref tree.Left);
            }
            else if (item.CompareTo(tree.Data) > 0)
            {
                InsertItem(item, ref tree.Right);
            }

            tree.BalanceFactor = Height(tree.Left) - Height(tree.Right);
            if (tree.BalanceFactor <= -2)
            {
                RotateLeft(ref tree);
            }
            else if (tree.BalanceFactor >= 2)
            {
                RotateRight(ref tree);
            }   
        }

        public new void RemoveItem(T item)
        {
            RemoveItem(item, ref root);
        }

        private void RemoveItem(T item, ref Node<T> tree)
        {
            if (item.CompareTo(tree.Data) < 0 && tree.Left != null)
            {
                RemoveItem(item, ref tree.Left);
            }
            else if (item.CompareTo(tree.Data) > 0 && tree.Right != null)
            {
                RemoveItem(item, ref tree.Right);
            }
            //Item found
            else if (tree.Left == null)
            {
                tree = tree.Right;
            }
            else if (tree.Right == null)
            {
                tree = tree.Left;
            }
            else
            {
                T newRoot = LeastItem(tree.Right);
                tree.Data = newRoot;
                RemoveItem(newRoot, ref tree.Right);
            }
        }

        private T LeastItem(Node<T> tree) //Used in RemoveItem
        {
            if (tree.Left == null) //Terminating condition
            {
                return tree.Data;
            }
            else
            {
                return LeastItem(tree.Left);
            }
        }

        private void RotateLeft(ref Node<T> tree)
        {
            if (tree.Right.BalanceFactor > 0) //Double rotation
            {
                RotateRight(ref tree.Right);
            }
            Node<T> oldRoot = tree; //Root node now becomes the oldRoot
            Node<T> newRoot = tree.Right; //New root becomes right node
            oldRoot.Right = newRoot.Left;
            newRoot.Left = oldRoot;
            tree = newRoot;

            /*if (tree.Left == null) //If nothing is to the left, move temp node to the left
            {
                tree.Left = oldRoot;
            }
            else
            {
                oldRoot.Right = tree.Left;
                tree.Left = oldRoot;
            }*/
        }

        private void RotateRight(ref Node<T> tree)
        {
            if (tree.Left.BalanceFactor < 0) //Double rotation
            {
                RotateLeft(ref tree.Left);
            }
            Node<T> oldRoot = tree; //Root node now becomes the oldRoot
            Node<T> newRoot = tree.Left; //New root becomes left node
            oldRoot.Left = newRoot.Right;
            newRoot.Right = oldRoot;
            tree = newRoot;

            /*if (tree.Right == null) //If nothing is to the right, move temp node to the right
            {
                tree.Right = temp;
            }
            else
            {
                temp.Left = tree.Right;
                tree.Right = temp;
            }*/
        }

        private void CheckBalance(Node<T> tree)
        {
            if(tree.Data != null)
            {
                tree.BalanceFactor = Height(tree.Left) - Height(tree.Right);
                if (tree.BalanceFactor <= -2 || tree.BalanceFactor >= 2) //If unbalanced, start to rebalance nodes
                {
                    ReinsertItem(tree);
                }
            }

            if (tree.Left != null)
            {
                CheckBalance(tree.Left);
            }
            if (tree.Right != null)
            {
                CheckBalance(tree.Right);
            }
        }

        private void ReinsertItem(Node<T> tree)
        {
            Node<T> temp = tree;
            RemoveItem(tree.Data);
            InsertItem(temp.Data);
        }
    }
}

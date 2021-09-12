using System;
using System.Collections.Generic;
using System.Text;

namespace CountriesAssignment
{
    class BSTree<T> : BinTree<T> where T : IComparable
    {
        public BSTree()
        {
            root = null;
        }

        public void InsertItem(T item)
        {
            InsertItem(item, ref root);
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
        }

        //Return the max level of the tree
        public int Height()
        {
            return Height(root);
        }

        protected int Height(Node<T> tree)
        {
            if (tree == null)
            {
                return 0;
            }
            else
            {
                return Math.Max(Height(tree.Left), Height(tree.Right)) + 1;
            }
        }

        //Return the number of nodes in the tree
        public int Count()
        {
            return Count(root);
        }

        private int Count(Node<T> tree)
        {
            if (tree == null) // Doesn't exist - don't count anything
            {
                return 0;
            }
            else
            {
                return 1 + Count(tree.Left) + Count(tree.Right); // Account for node currently on, then nodes left and right
            }
        }

        //Return true if the item is contained in the BSTree, false otherwise.
        public Boolean Contains(T item)
        {
            return Contains(item, root);
        }

        public Boolean Contains(T item, Node<T> tree)
        {
            if (tree == null) // Node doesn't exist
            {
                return false;
            }
            if (item.CompareTo(tree.Data) == 0) // Found item we're looking for
            {
                return true;
            }
            if (item.CompareTo(tree.Data) < 0) // Less than so go left
            {
                return Contains(item, tree.Left);
            }
            else if (item.CompareTo(tree.Data) > 0) // Greater than so go right
            {
                return Contains(item, tree.Right);
            }
            return false; // Not found, return false
        }

        public void RemoveItem(T item)
        {
            RemoveItem(item, ref root);
        }

        private void RemoveItem(T item, ref Node<T> tree)
        {
            if (tree == null) // Tree empty - do nothing
            {
                return;
            }
            if (item.CompareTo(tree.Data) < 0) // Look left if item less than tree.Data
            {
                RemoveItem(item, ref tree.Left);
            }
            else if (item.CompareTo(tree.Data) > 0) // Look right if item greater than tree.Data
            {
                RemoveItem(item, ref tree.Right);
            }

            if (tree.Left == null && tree.Right == null) // Found item
            {
                tree = tree.Right;
            }
        }
    }
}

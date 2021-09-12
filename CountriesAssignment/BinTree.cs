using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountriesAssignment
{
    class BinTree<T> where T : IComparable
    {
        protected Node<T> root;

        public BinTree() // Creates an empty tree
        {
            root = null;
        }

        public BinTree(Node<T> node) // Creates a tree with node as the root
        {
            root = node;
        }

        public void PreOrder(ref string buffer)
        {
            PreOrder(root, ref buffer);
        }

        private void PreOrder(Node<T> tree, ref string buffer)
        {
            if (tree != null)
            {
                buffer += tree.Data.ToString() + ",";
                PreOrder(tree.Left, ref buffer);
                PreOrder(tree.Right, ref buffer);
            }
        }

        public void InOrder(ref string buffer)
        {
            InOrder(root, ref buffer);
        }

        private void InOrder(Node<T> tree, ref string buffer)
        {
            if (tree != null)
            {
                InOrder(tree.Left, ref buffer);
                buffer += tree.Data.ToString() + ",";
                InOrder(tree.Right, ref buffer);
            }
        }

        public void PostOrder(ref string buffer)
        {
            PostOrder(root, ref buffer);
        }

        private void PostOrder(Node<T> tree, ref string buffer)
        {
            if (tree != null)
            {
                PostOrder(tree.Left, ref buffer);
                PostOrder(tree.Right, ref buffer);
                buffer += tree.Data.ToString() + ",";
            }
        }

        public void Copy(BinTree<T> tree2)
        {
            Copy(ref root, tree2.root);
        }

        private void Copy(ref Node<T> tree, Node<T> tree2)
        {

        }
    }
}

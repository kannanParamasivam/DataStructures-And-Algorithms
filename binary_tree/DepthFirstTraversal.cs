using System;
using System.Collections.Generic;
using System.Text;

namespace binary_tree
{
    public class DepthFirstTraversal<T>
    {
        StringBuilder outputBuilder;

        public DepthFirstTraversal()
        {
            this.outputBuilder = new StringBuilder();
        }

        public string Output => this.outputBuilder.ToString();

        public void PreOrder(Node<T> node)
        {
            if (node == null)
                return;

            this.outputBuilder.Append(node.getData().ToString());

            PreOrder(node.GetLeftChild());
            PreOrder(node.GetRightChild());
        }

        public void InOrder(Node<T> node)
        {
            if (node == null)
                return;

            InOrder(node.GetLeftChild());
            this.outputBuilder.Append(node.getData().ToString());
            InOrder(node.GetRightChild());
        }

        public void PostOrder(Node<T> node)
        {
            if (node == null)
                return;

            PostOrder(node.GetLeftChild());
            PostOrder(node.GetRightChild());
            this.outputBuilder.Append(node.getData().ToString());
        }
    }
}

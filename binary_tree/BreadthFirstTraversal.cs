using System;
using System.Collections.Generic;
using System.Text;

namespace binary_tree
{
    public class BreadthFirstTraversal<T>
    {
        Queue<Node<T>> queue;

        public BreadthFirstTraversal()
        {
            this.queue = new Queue<Node<T>>();
        }

        public String Traverse(Node<T> root)
        {
            StringBuilder outputBuilder = new StringBuilder();

            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                Node<T> node = queue.Dequeue();

                if (outputBuilder.Length != 0)
                    outputBuilder.Append(',');
                outputBuilder.Append(node.getData().ToString());

                if (node.GetLeftChild() != null)
                    queue.Enqueue(node.GetLeftChild());

                if (node.GetRightChild() != null)
                    queue.Enqueue(node.GetRightChild());
            }

            return outputBuilder.ToString();
        }
    }
}

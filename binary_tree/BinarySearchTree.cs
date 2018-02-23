using System;
using System.Collections.Generic;
using System.Text;

namespace binary_tree
{
    public class BinarySearchTree
    {
        public static Node<int> Insert(Node<int> head, Node<int> node)
        {
            if (head == null)
                return node;

            if (node.getData() <= head.getData())
            {
                if (head.GetLeftChild() == null)
                {
                    head.SetLeftChild(node);
                }
                else
                {
                    return Insert(head.GetLeftChild(), node);
                }
            }
            else
            {
                if (head.GetRightChild() == null)
                {
                    head.SetRightChild(node);
                }
                else
                {
                    return Insert(head.GetRightChild(), node);
                }
            }

            return head;
        }

        public static Node<int> Lookup(Node<int> head, int data)
        {
            if (head == null)
                return null;

            if (head.getData().Equals(data))
                return head;

            if (data <= head.getData())
                return Lookup(head.GetLeftChild(), data);
            else
                return Lookup(head.GetRightChild(), data);
        }
    }
}

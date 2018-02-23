using System;
using System.Collections.Generic;

namespace binary_tree
{
    public class Node<T>
    {
        private T data;
        private Node<T> leftChild;
        private Node<T> rightChild;

        public Node(T nodeData)
        {
            this.data = nodeData;
        }

        public T getData()
        {
            return this.data;
        }

        public void SetLeftChild(Node<T> leftChild)
        {
            this.leftChild = leftChild;
        }

        public Node<T> GetLeftChild()
        {
            return this.leftChild;
        }

        public void SetRightChild(Node<T> rightChild)
        {
            this.rightChild = rightChild;
        }

        public Node<T> GetRightChild()
        {
            return this.rightChild;
        }
    }
}

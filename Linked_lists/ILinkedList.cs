using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_lists
{
    interface ILinkedList<T>
    {
        Node<T> Head { get; }

        Node<T> Tail { get; }

        int Size { get; }

        Node<T> Add(T data);

        bool Delete(Node<T> node);

        Node<T> AddFirst(T data);

        Node<T> AddAfter(Node<T> refNode, T data);
    }
}

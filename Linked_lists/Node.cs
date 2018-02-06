using System;

namespace Linked_lists
{
    public class Node<T>
    {
        public Node<T> Previous { get; set; }

        public T Data { get; set; }

        public Node<T> Next { get; set; }

        public bool HasNext()
        {
            return Next != null;
        }

        public bool HasPrevious()
        {
            return Previous != null;
        }

        public override string ToString()
        {
            return this.Data.ToString();
        }
    }
}

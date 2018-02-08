using linkedlist_with_sigle_element;
using System;

namespace stack
{
    public class Stack<T> : IStack<T>
    {
        private int MAX_SIZE = 30;
        private int size = 0;
        private IElement<T> top;

        public int GetMaxSize()
        {
            return this.MAX_SIZE;
        }

        public int GetSize()
        {
            return this.size;
        }

        public T POP()
        {
            if (this.size == 0)
            {
                throw new StackUnderflowException();
            }

            T data = top.GetData();
            top = top.GetNext();
            this.size--;
            return data;
        }

        public T PEEK()
        {
            if (this.size == 0)
            {
                throw new StackUnderflowException();
            }

            return top.GetData();
        }

        public void PUSH(T data)
        {
            if (this.MAX_SIZE == this.size)
            {
                throw new StackOverflowException();
            }

            IElement<T> newEelement = new Element<T>(data, top);
            this.top = newEelement;
            this.size++;
        }

        public bool IsEmpty()
        {
            return this.size == 0;
        }

        public bool IsFull()
        {
            return this.MAX_SIZE == this.size;
        }
    }
}

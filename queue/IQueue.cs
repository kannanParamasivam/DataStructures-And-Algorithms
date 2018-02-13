using System;
using System.Collections.Generic;
using System.Text;

namespace queue
{
    public interface IQueue<T>
    {
        Array CircularArray { get; }
        void ENQUEUE(T data);
        T DEQUEUE();
        T PEEK();
        bool IsEmpty();
        bool IsFull();
        bool OFFER();
        bool IsSingleElementPresent();
    }
}

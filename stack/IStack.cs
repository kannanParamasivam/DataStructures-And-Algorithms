using linkedlist_with_sigle_element;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    public interface IStack<T>
    {
        int GetMaxSize();
        int GetSize();
        T POP();
        T PEEK();
        void PUSH(T data);
        bool IsEmpty();
        bool IsFull();
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace problem_solving_using_stack
{
    /// <summary>
    /// Get minimum in O(1) at any point of time
    /// </summary>
    public class MinimumStack : IMinimumStack
    {
        Stack.Stack<int> dataStack;
        Stack.Stack<int> minimumStack;

        public MinimumStack()
        {
            this.dataStack = new Stack.Stack<int>();
            this.minimumStack = new Stack.Stack<int>();
        }

        public void PUSH(int data)
        {
            dataStack.PUSH(data);

            if (minimumStack.IsEmpty())
                minimumStack.PUSH(data);
            else
                minimumStack.PUSH(data < minimumStack.PEEK() ? data : minimumStack.PEEK());
        }

        public int POP()
        {
            minimumStack.POP();
            return dataStack.POP();
        }

        public int GetMinimum()
        {
            return minimumStack.PEEK();
        }
    }
}

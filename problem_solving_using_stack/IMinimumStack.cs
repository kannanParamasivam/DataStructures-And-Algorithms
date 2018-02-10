using System;
using System.Collections.Generic;
using System.Text;

namespace problem_solving_using_stack
{
    public interface IMinimumStack
    {
        void PUSH(int v);
        int POP();
        int GetMinimum();
    }
}

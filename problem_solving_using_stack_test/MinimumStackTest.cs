using problem_solving_using_stack;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace problem_solving_using_stack_test
{
    public class MinimumStackTest
    {
        IMinimumStack minimumStack;

        public MinimumStackTest()
        {
            minimumStack = new MinimumStack();
        }

        [Fact]
        public void PUSH_WhenCalled_ShouldPushDataIntoMinStack()
        {
            minimumStack.PUSH(3);
            Assert.Equal(3, minimumStack.POP());
        }

        [Fact]
        public void PUSH_WhenCalledMoreThanOneTime_ShouldPushDataIntoMinStack()
        {
            minimumStack.PUSH(3);
            minimumStack.PUSH(6);
            minimumStack.PUSH(9);
            Assert.Equal(9, minimumStack.POP());
            Assert.Equal(6, minimumStack.POP());
            Assert.Equal(3, minimumStack.POP());
        }

        [Fact]
        public void GetMinimum_WhenCalled_ShouldGiveMinimumAtThatPoint() {
            minimumStack.PUSH(6);
            minimumStack.PUSH(1);
            minimumStack.PUSH(3);
            Assert.Equal(1, minimumStack.GetMinimum());
        }

        [Fact]
        public void GetMinimum_WhenStackIsEmpty_ShouldThrowException()
        {
            Assert.Throws<Stack.StackUnderflowException>(()=>minimumStack.GetMinimum());
        }

        [Fact]
        public void GetMinimum_WhenSingleElement_ShouldReturnTheSingleElementPresent() {
            minimumStack.PUSH(9);
            Assert.Equal(9, minimumStack.GetMinimum());
        }





    }
}

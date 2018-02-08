using stack;
using System;
using Xunit;

namespace stack_test
{
    public class StackTest
    {
        private IStack<string> _stack;

        public StackTest()
        {
            this._stack = new Stack<string>();
        }

        [Fact]
        public void GetMaxSize_WhenCalled_ShouldReturnNonNegativeNumber()
        {
            Assert.True(this._stack.GetMaxSize() >= 0);
        }

        [Fact]
        public void GetSize_WhenCalled_ShouldReturnNonNegativeNumber()
        {
            Assert.True(this._stack.GetSize() >= 0);
        }

        [Fact]
        public void POP_WhenSizeIsZero_ShouldThrowStackUnderFlowException()
        {
            Assert.Equal(0, this._stack.GetSize());
            Assert.Throws<stack.StackUnderflowException>(() => _stack.POP());
        }

        [Fact]
        public void PEEK_WhenSizeIsZero_ShouldThrowStackUnderFlowException()
        {
            Assert.Equal(0, this._stack.GetSize());
            Assert.Throws<stack.StackUnderflowException>(() => _stack.PEEK());
        }

        [Fact]
        public void PUSH_WhenCalled_ShouldCreateAnElementOnTop()
        {
            string data = "first element";
            this._stack.PUSH(data);
            Assert.Equal(1, this._stack.GetSize());
            Assert.Equal(data, this._stack.PEEK());
        }

        [Fact]
        public void GetSize_WhenCalled_ShouldReturnCorrectSize()
        {
            Assert.Equal(0, this._stack.GetSize());

            this._stack.PUSH("first Element");
            this._stack.PUSH("SecondElement");

            Assert.Equal(2, this._stack.GetSize());
        }

        [Fact]
        public void GetSeize_WhenAfterPOP_ShouldReturnUpdatedSize()
        {
            this._stack.PUSH("first Element");
            this._stack.PUSH("SecondElement");

            Assert.Equal(2, this._stack.GetSize());

            this._stack.POP();

            Assert.Equal(1, this._stack.GetSize());
        }

        [Fact]
        public void POP_WhenCalled_ShouldReturnAndRemoveTopElement()
        {
            string firstElementData = "first Element";
            string secondElementData = "Second Element";
            this._stack.PUSH(firstElementData);
            this._stack.PUSH(secondElementData);

            Assert.Equal(secondElementData, this._stack.POP());
            Assert.Equal(firstElementData, this._stack.PEEK());
        }

        [Fact]
        public void PEEK_WhenCalled_ShouldReturnTopReference()
        {
            string firstElementData = "first Element";
            string secondElementData = "Second Element";
            this._stack.PUSH(firstElementData);
            this._stack.PUSH(secondElementData);

            Assert.Equal(secondElementData, this._stack.PEEK());
        }

        [Fact]
        public void PEEK_WhenCalled_ShouldNotRemoveTop()
        {
            string firstElementData = "first Element";
            string secondElementData = "Second Element";
            this._stack.PUSH(firstElementData);
            this._stack.PUSH(secondElementData);

            Assert.Equal(secondElementData, this._stack.PEEK());
            Assert.Equal(2, this._stack.GetSize());
            Assert.Equal(secondElementData, this._stack.PEEK());
        }

        [Fact]
        public void PUSH_WhenCalledAfterMaximumSizeReached_ShouldThrowStackOverflowException()
        {
            for (int i = 0; i < this._stack.GetMaxSize(); i++)
            {
                this._stack.PUSH(i.ToString());
            }

            Assert.Equal(this._stack.GetMaxSize(), this._stack.GetSize());
            Assert.Throws<stack.StackOverflowException>(() => this._stack.PUSH("new data"));
        }
    }
}

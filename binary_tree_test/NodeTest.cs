using binary_tree;
using System;
using Xunit;

namespace binary_tree_test
{
    public class NodeTest
    {
        Node<string> node;
        string nodeData = "test node data";

        public NodeTest()
        {
            node = new Node<string>(nodeData);
        }

        [Fact]
        public void Contructor_WhenCalled_ShouldSetData()
        {
            Assert.Equal(nodeData, node.getData());
        }

        [Fact]
        public void SetLeftChild_WhenCalled_ShouldSetLeftChild()
        {
            Node<string> leftChild = new Node<string>("left child data");
            node.SetLeftChild(leftChild);
            Assert.Equal(leftChild, node.GetLeftChild());
        }

        [Fact]
        public void SetRightChild_WhenCalled_ShouldSetRightChild()
        {
            Node<string> rightChild = new Node<string>("left child data");
            node.SetRightChild(rightChild);
            Assert.Equal(rightChild, node.GetRightChild());
        }
    }
}

using binary_tree;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace binary_tree_test
{
    public class BreadthFirstTraversalTest
    {
        BreadthFirstTraversal<string> breadthFirstTraversal;

        public BreadthFirstTraversalTest() => this.breadthFirstTraversal = new BreadthFirstTraversal<string>();

        [Fact]
        public void Traverse_WhenCalled_ShouldReturnElementsInBreadthFirstOrder()
        {
            Node<string> root = new Node<string>("A");
            Node<string> nodeB = new Node<string>("B");
            Node<string> nodeC = new Node<string>("C");
            Node<string> nodeD = new Node<string>("D");
            Node<string> nodeE = new Node<string>("E");
            Node<string> nodeF = new Node<string>("F");
            Node<string> nodeG = new Node<string>("G");

            root.SetLeftChild(nodeB);
            root.SetRightChild(nodeC);

            nodeB.SetLeftChild(nodeD);
            nodeB.SetRightChild(nodeE);

            nodeC.SetLeftChild(nodeF);
            nodeC.SetRightChild(nodeG);

            Assert.Equal("A,B,C,D,E,F,G", this.breadthFirstTraversal.Traverse(root));
        }
    }
}

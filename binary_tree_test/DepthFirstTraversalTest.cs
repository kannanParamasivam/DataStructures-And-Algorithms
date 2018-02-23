using binary_tree;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace binary_tree_test
{
    public class DepthFirstTraversalTest
    {
        DepthFirstTraversal<string> depthFirstTraversal;

        public DepthFirstTraversalTest()
        {
            depthFirstTraversal = new DepthFirstTraversal<string>();
        }

        [Fact]
        public void PreOrder_WhenCalled_ShouldReturnElementsInDepthFirstPreOrder()
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

            this.depthFirstTraversal.PreOrder(root);

            Assert.Equal("ABDECFG", depthFirstTraversal.Output);
        }

        [Fact]
        public void PreOrder_WhenCalled_ShouldReturnElementsInDepthFirstInOrder()
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

            this.depthFirstTraversal.InOrder(root);

            Assert.Equal("DBEAFCG", depthFirstTraversal.Output);
        }

        [Fact]
        public void PreOrder_WhenCalled_ShouldReturnElementsInDepthFirstPostOrder()
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

            this.depthFirstTraversal.PostOrder(root);

            Assert.Equal("DEBFGCA", depthFirstTraversal.Output);
        }
    }
}

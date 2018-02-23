using binary_tree;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace binary_tree_test
{
    public class BinarySearchTreeTest
    {
        Node<int> root;
        BreadthFirstTraversal<int> breadthFirstTraversal;

        public BinarySearchTreeTest()
        {
            root = new Node<int>(8);
            breadthFirstTraversal = new BreadthFirstTraversal<int>();
        }

        [Fact]
        public void Insert_WhenInsertElements_ShouldInsertInBinarySearchFashion()
        {
            Node<int>[] nodes = {
                new Node<int>(6),
                new Node<int>(14),
                new Node<int>(4),
                new Node<int>(7),
                new Node<int>(16),
                new Node<int>(15),
                new Node<int>(18)
            };

            foreach (Node<int> node in nodes)
            {
                BinarySearchTree.Insert(root, node);
            }

            Assert.Equal("8,6,14,4,7,16,15,18", this.breadthFirstTraversal.Traverse(root));
        }

        [Fact]
        public void Lookup_WhenCalledWithValuePresentInTheTree_ShouldReturnTheNode()
        {
            Node<int>[] nodes = {
                new Node<int>(6),
                new Node<int>(14),
                new Node<int>(4),
                new Node<int>(7),
                new Node<int>(16),
                new Node<int>(15),
                new Node<int>(18)
            };

            foreach (Node<int> node in nodes)
            {
                BinarySearchTree.Insert(root, node);
            }
            Node<int> resultNode = BinarySearchTree.Lookup(this.root, 18);
            Assert.NotNull(resultNode);
            Assert.Equal(18, resultNode.getData());
        }

        [Fact]
        public void Lookup_WhenLookupValueNotPresent_ShouldReturnNull()
        {
            Node<int>[] nodes = {
                new Node<int>(6),
                new Node<int>(14),
                new Node<int>(4),
                new Node<int>(7),
                new Node<int>(16),
                new Node<int>(15),
                new Node<int>(18)
            };

            foreach (Node<int> node in nodes)
            {
                BinarySearchTree.Insert(root, node);
            }

            Node<int> resultNode = BinarySearchTree.Lookup(this.root, 20);
            Assert.Null(resultNode);
        }
    }
}

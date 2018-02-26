using binary_tree;
using binary_tree_problem_solving;
using System;
using System.Text;
using Xunit;

namespace binary_tree_problem_solving_test
{
    public class BinarySearchTreeProblemSolverTest
    {
        public BinarySearchTreeProblemSolverTest()
        {
            BinarySearchTreeProblemSolver.PrintedOutput = new StringBuilder();
        }

        [Fact]
        public void FindMinimumValue_WhenCalled_ShouldReturnMinimumValueInTheTree()
        {
            Node<int> root = new Node<int>(8);
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

            int result = BinarySearchTreeProblemSolver.FindMinimumValue(root);
            Assert.NotEqual(int.MinValue, result);
            Assert.Equal(4, result);
        }

        [Fact]
        public void FindMinimumValue_WhenHeadIsNull_ShouldReturnMinimumIntegerValue()
        {
            Node<int> root = null;
            int result = BinarySearchTreeProblemSolver.FindMinimumValue(root);
            Assert.Equal(int.MinValue, result);
        }

        [Fact]
        public void FindMaxDepth_WhenCalled_ShouldReturnMinimumValueInTheTree()
        {
            Node<int> root = new Node<int>(8);
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

            Assert.Equal(3, BinarySearchTreeProblemSolver.FindMaxDepth(root));
        }

        [Fact]
        public void FindMaxDepth_WhenNoElementsPresent_ShouldReturnNegativeOne()
        {
            Assert.Equal(-1, BinarySearchTreeProblemSolver.FindMaxDepth(null));
        }

        [Fact]
        public void FindMaxDepth_WhenOnlyHeadNodePresent_ShouldReturnZero()
        {
            Assert.Equal(0, BinarySearchTreeProblemSolver.FindMaxDepth(new Node<int>(3)));
        }

        [Fact]
        public void Mirror_WhenCalled_AlterThePositionsOfTheNodes()
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

            BreadthFirstTraversal<string> breadthFirstTraversal = new BreadthFirstTraversal<string>();
            Assert.Equal("A,B,C,D,E,F,G", breadthFirstTraversal.Traverse(root));
            BinarySearchTreeProblemSolver.Mirror(root);
            Assert.Equal("A,C,B,G,F,E,D", breadthFirstTraversal.Traverse(root));
        }

        [Fact]
        public void NumberOfTreesPossible_WhenNumberOfNodesProvided_ShouldGiveNumberOfStcturallyUniqueueBinaryTreesPossible()
        {
            int numberOfTreesPossible = BinarySearchTreeProblemSolver.NumberOfTreesPossible(numberOfNodes: 3);
            Assert.Equal(5, numberOfTreesPossible);
        }

        [Fact]
        public void PrintRange_WhenCalled_ShouldReturnMinimumValueInTheTree()
        {
            Node<int> root = new Node<int>(8);
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

            BinarySearchTreeProblemSolver.PrintRange(head: root, low: 4, high: 15);

            Assert.Equal("4,6,7,8,14,15", BinarySearchTreeProblemSolver.PrintedOutput.ToString());
        }

        [Fact]
        public void IsBinarySearchTree_WhenItIsBinarySearchTree_ShouldReturnTrue()
        {
            Node<int> root = new Node<int>(8);
            Node<int> nodeB = new Node<int>(6);
            Node<int> nodeC = new Node<int>(14);
            Node<int> nodeD = new Node<int>(4);
            Node<int> nodeE = new Node<int>(7);
            Node<int> nodeF = new Node<int>(16);
            Node<int> nodeG = new Node<int>(15);
            Node<int> nodeH = new Node<int>(18);

            root.SetLeftChild(nodeB);
            root.SetRightChild(nodeC);

            nodeB.SetLeftChild(nodeD);
            nodeB.SetRightChild(nodeE);

            nodeC.SetRightChild(nodeF);

            nodeF.SetLeftChild(nodeG);
            nodeF.SetRightChild(nodeH);

            Assert.True(BinarySearchTreeProblemSolver.IsBinarySearchTree(root));
        }

        [Fact]
        public void IsBinarySearchTree_WhenItIsNotBinarySearchTree_ShouldReturnFalse()
        {
            Node<int> root = new Node<int>(8);
            Node<int> nodeB = new Node<int>(14);
            Node<int> nodeC = new Node<int>(6);
            Node<int> nodeD = new Node<int>(4);
            Node<int> nodeE = new Node<int>(7);
            Node<int> nodeF = new Node<int>(15);
            Node<int> nodeG = new Node<int>(14);
            Node<int> nodeH = new Node<int>(17);
            Node<int> nodeI = new Node<int>(16);

            root.SetLeftChild(nodeB);
            root.SetRightChild(nodeC);

            nodeB.SetLeftChild(nodeD);
            nodeB.SetRightChild(nodeE);

            nodeC.SetLeftChild(nodeF);
            nodeC.SetRightChild(nodeG);

            nodeD.SetLeftChild(nodeH);
            nodeD.SetRightChild(nodeI);

            Assert.False(BinarySearchTreeProblemSolver.IsBinarySearchTree(root));
        }
    }
}

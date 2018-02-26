using binary_tree;
using System;
using System.Collections.Generic;
using System.Text;

namespace binary_tree_problem_solving
{
    public class BinarySearchTreeProblemSolver
    {
        public static StringBuilder PrintedOutput { get; set; }

        public static int FindMinimumValue(Node<int> head)
        {
            if (head == null)
                return int.MinValue;

            Node<int> currentNode = head;
            while (currentNode.GetLeftChild() != null)
            {
                currentNode = currentNode.GetLeftChild();
            }
            return currentNode.getData();
        }

        public static int FindMaxDepth(Node<int> head)
        {
            if (head == null)
                return -1;

            int leftDepth = 1 + FindMaxDepth(head.GetLeftChild());
            int rightDepth = 1 + FindMaxDepth(head.GetRightChild());

            return Math.Max(leftDepth, rightDepth);
        }

        public static void Mirror(Node<string> head)
        {
            if (head == null)
                return;

            Mirror(head.GetLeftChild());
            Mirror(head.GetRightChild());

            Node<string> temp = head.GetLeftChild();
            head.SetLeftChild(head.GetRightChild());
            head.SetRightChild(temp);
        }

        public static int NumberOfTreesPossible(int numberOfNodes)
        {
            if (numberOfNodes <= 1)
                return 1;

            int sum = 0;
            for (int i = 1; i <= numberOfNodes; i++)
            {
                int numberOfLeftTrees = NumberOfTreesPossible(i - 1);
                int numberOfRightTrees = NumberOfTreesPossible(numberOfNodes - i);
                sum += numberOfLeftTrees * numberOfRightTrees;
            }

            return sum;
        }

        public static void PrintRange(Node<int> head, int low, int high)
        {
            if (head == null)
                return;

            if (low <= head.getData())
                PrintRange(head.GetLeftChild(), low, high);

            if (head.getData() >= low && head.getData() <= high)
                PrintedOutput.Append(PrintedOutput.Length > 0 ? ',' + head.getData().ToString() : head.getData().ToString());

            if (high > head.getData())
                PrintRange(head.GetRightChild(), low, high);
        }

        public static bool IsBinarySearchTree(Node<int> head)
        {
            if ((head == null) || (head.GetLeftChild() == null & head.GetRightChild() == null))
                return true;

            if (head.GetLeftChild() != null && head.GetLeftChild().getData() > head.getData())
                return false;

            if (head.GetRightChild() != null && head.GetRightChild().getData() <= head.getData())
                return false;

            return IsBinarySearchTree(head.GetLeftChild()) && IsBinarySearchTree(head.GetRightChild());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_lists
{
    public class LinkedList<T> : ILinkedList<T>
    {
        #region Private Fields
        private Node<T> _head;

        private Node<T> _tail;

        private int _size;
        #endregion

        #region Public Members
        public Node<T> Head { get { return _head; } }

        public Node<T> Tail { get { return _tail; } }

        public int Size { get { return this._size; } }

        public Node<T> Add(T data)
        {

            if (data != null)
            {
                Node<T> newNode = new Node<T>
                {
                    Data = data,
                    Next = null
                };

                if (this.Head == null)
                {
                    newNode.Previous = null;
                    this._head = newNode;
                    this._tail = newNode;
                }
                else
                {

                    this._tail.Next = newNode;
                    newNode.Previous = this._tail;
                    this._tail = newNode;
                }

                this._size++;

                return newNode;
            }
            else
                return null;
        }

        public bool Delete(Node<T> node)
        {

            Node<T> currentNode = this._head;

            do
            {
                if (currentNode == node)
                {
                    if (!IsHead(currentNode))
                        LinkPreviousNodeToNextNode(currentNode);

                    if (!IsTail(currentNode))
                        LinkNextNodeToPreviousNode(currentNode);

                    if (IsHead(currentNode))
                        UpdateHead(currentNode.Next);

                    if (IsTail(currentNode))
                        UpdateTail(currentNode.Previous);

                    RemoveLinks(currentNode);

                    this._size--;
                    return true;
                }
                else if (currentNode.HasNext())
                {
                    currentNode = currentNode.Next;
                }

            } while (currentNode != null);

            return false;
        }

        public Node<T> AddFirst(T data)
        {
            Node<T> newNode = new Node<T>
            {
                Data = data,
                Next = this._head,
            };

            this._head = newNode;

            _size++;

            return newNode;
        }

        public Node<T> AddAfter(Node<T> refNode, T data)
        {
            if (refNode != null && data != null)
            {
                Node<T> newNode = new Node<T>
                {
                    Data = data
                };

                if (this._head != null)
                {
                    Node<T> currentNode = this._head;

                    do
                    {
                        if (currentNode == refNode)
                        {
                            newNode.Next = currentNode.Next;
                            newNode.Previous = currentNode;
                            currentNode.Next = newNode;
                            break;
                        }
                        if (currentNode.HasNext())
                        {
                            currentNode = currentNode.Next;
                        }
                        else
                        {
                            break;
                        }
                    } while (currentNode != null);
                }
                else
                {
                    this._head = newNode;
                    this._size++;
                }

                return newNode;
            }
            else
                return null;
        }
        #endregion

        #region Helper Methods
        private void UpdateTail(Node<T> node)
        {
            this._tail = node;
        }

        private void UpdateHead(Node<T> node)
        {
            this._head = node;
        }

        private static void RemoveLinks(Node<T> currentNode)
        {
            currentNode.Previous = null;
            currentNode.Next = null;
        }

        private static void LinkNextNodeToPreviousNode(Node<T> currentNode)
        {
            currentNode.Next.Previous = currentNode.Previous;
        }

        private static void LinkPreviousNodeToNextNode(Node<T> currentNode)
        {
            currentNode.Previous.Next = currentNode.Next;
        }

        private static bool IsTail(Node<T> currentNode)
        {
            return currentNode.Next == null;
        }

        private static bool IsHead(Node<T> currentNode)
        {
            return currentNode.Previous == null;
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_lists
{
    public class LinkedList<T>
    {
        private Node<T> _head;

        private Node<T> _tail;

        private int _size;

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
                    currentNode.Previous.Next = currentNode.Next;
                    currentNode.Next.Previous = currentNode.Previous;
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


    }
}

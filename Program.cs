using Linked_lists;
using System;

namespace DataStructures_and_algorithms_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //BigONotation bigONotation = new BigONotation();
            //bigONotation.TwoForLoopsCompletelyStraightForward(10);



            //TryLinkedList();

            Console.ReadKey();
        }

        private static void TryLinkedList()
        {
            LinkedList<string> linkedList = new LinkedList<string>();

            linkedList.Add("head");
            Node<string> firstNode = linkedList.Add("first_element");
            linkedList.Add("last_element");

            PrintList(linkedList);

            Console.WriteLine("Adding new head");
            linkedList.AddFirst("new_head");
            PrintList(linkedList);

            Console.WriteLine("Adding new second");
            linkedList.AddAfter(firstNode, "new second");
            PrintList(linkedList);

            Console.WriteLine("Adding to be deleted after first");
            Node<string> toBeDeleted = linkedList.AddAfter(firstNode, "to be deleted");
            PrintList(linkedList);

            Console.WriteLine("Deleting to be deleted");
            linkedList.Delete(toBeDeleted);
            PrintList(linkedList);
        }

        private static void PrintList(LinkedList<string> linkedList)
        {
            Console.WriteLine("Size of the list is " + linkedList.Size);

            if (linkedList.Head != null)
            {
                Node<String> currentNode = linkedList.Head;
                Console.WriteLine(linkedList.Head.ToString());

                while (currentNode.HasNext())
                {
                    currentNode = currentNode.Next;
                    Console.WriteLine(currentNode.ToString());
                }

                Console.WriteLine();
            }
        }
    }
}

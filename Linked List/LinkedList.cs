using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16.Linked_List
{
    public class LinkedList
    {
        public Node? First { get; set; }
        public void InsertFirst(int data)
        {
            // Creating the node
            Node newNode = new Node();
            // Put the data in the node
            newNode.Data = data;
            // Put the old node in next
            newNode.Next = First;
            // Make the first the new node
            First = newNode;
        }
        public Node DeleteFirst()
        {
            // Assign the temporary variable
            Node temp = First;
            // Assign the next head
            First = First.Next;
            return temp;
        }
        public void DisplayList()
        {
            Console.WriteLine("Iterating thru list");
            Node currentNode = First;
            while (currentNode != null)
            {
                currentNode.DisplayNode();
                currentNode = currentNode.Next;
            }
        }
        public void InsertLast(int data)
        {
            Node currentNode = First;
            while (currentNode.Next != null)
            {
                currentNode = currentNode.Next;
            }
            Node newNode = new Node();
            newNode.Data = data;
            currentNode.Next = newNode;
        }
    }
}

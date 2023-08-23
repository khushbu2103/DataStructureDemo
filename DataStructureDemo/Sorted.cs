using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureDemo
{
    internal class Sorted
    {
        public Node head;
        public void Add(int data)
        {
            Node newNode = new Node(data);
            if (head == null || head.data >= data)
            {
                newNode.next = head;
                head = newNode;
            }
            else
            {
                Node currentNode = head;
                while (currentNode.next != null && currentNode.next.data < data)
                {
                    currentNode = currentNode.next;
                }
                newNode.next = currentNode.next;
                currentNode.next = newNode;
            }
            Console.WriteLine("\n{0} is added into SortedLinkedList", data);
        }

        public void Display()
        {
            if (head == null)
            {
                Console.Write("no data present in linked list");
            }
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
            }
        }
    }
}

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataStructureDemo
{
    internal class CustomLinkedList
    {
        public Node head;

        public void AddLast(int data)
        {
            Node newnode = new Node(data);

           if(head == null)
            {
                head = newnode;
                Console.WriteLine("{0} is added into new node", data);
            }
           else
            {
                Node lastNode = GetlastNode();
                lastNode.next = newnode;
                Console.WriteLine("{0} is added into new node", data);
            }
        }

        
        public Node GetlastNode()
        {
            Node temp = head;
            while(temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }

        public void AddFirst(int data)
        {
            Node newnode = new Node(data);
            newnode.next = head;
            head = newnode;
            Console.WriteLine("{0} is added into linked list", newnode.data);
        }
        public void Display()
        {
            if(head == null)
            {
                Console.Write("no data present in linked list");
            }
            else
            {
                Node temp = head;
                while(temp != null)
                {
                    Console.Write(temp.data+ " ");
                    temp = temp.next;
                }
            }
        }
    }
}

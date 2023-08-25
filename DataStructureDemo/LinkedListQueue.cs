using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureDemo
{
    internal class LinkedListQueue
    {
        public Node head;
        public void Enqueue(int item)
        {
            Node new_Node = new Node(item);
            if(this.head == null)
            {
                this.head = new_Node;
            }
            else
            {
               Node temp = this.head;
               while(temp.next != null)
                {
                   temp = temp.next;
                }
               temp.next = new_Node;
            }
            Console.WriteLine("{0} is Inserted into list ", new_Node.data);
        }

        public void Display()
        {
            if (head != null)
            {
                Node temp = head;
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
            }
            else
            {
                Console.Write("no data present in linked list");
            }
        }
    }
}

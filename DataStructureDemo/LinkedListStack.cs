using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureDemo
{
    internal class LinkedListStack
    {
        public Node top;
        public void Push(int data)
        {
            Node newNode = new Node(data);
            if(top == null)
            {
                top = newNode;
                Console.WriteLine("{0} is added on the top level in the stack", data) ;
            }
            else
            {
                newNode.next = top;
                top = newNode;
                Console.WriteLine("{0} is added on the top level in the stack", data);
            }
        }
        public void Display()
        {
            if (top != null)
            {
                Node temp = top;
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

        public void Peek()
        {
            if(top != null)
            {
                Console.WriteLine("\n{0} is to top most element of stack", top.data);
            }
            else
            {
                Console.WriteLine("stack is empty");
            }
        }

        public void Pop()
        {
            if(top.data != 0)
            {
                Console.WriteLine("{0} is deleted from stack", top.data);
                top = top.next;
            }
            else
            {
                Console.WriteLine("stack is empty");
            }
        }
        public void MakeStakeEmpty()
        {
            while(top != null)
            {
                Peek();
                Pop();
            }
            Console.WriteLine("\nStack is empty");
        }
    }
}

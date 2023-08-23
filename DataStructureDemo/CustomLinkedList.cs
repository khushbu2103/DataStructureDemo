using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
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

        public void Append(int data)
        {
            AddLast(data);
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

        public void InsertAfter(int data, int newData)
        {
            Node newNode = new Node(newData);
            Node currentNode = head;
            while (currentNode != null && currentNode.data != data)
            {
                currentNode = currentNode.next;
            }
            if (currentNode != null)
            {
                newNode.next = currentNode.next;
                currentNode.next = newNode;
                Console.WriteLine("{0} is inserted into CustomLinkedList after {1}", newData, data);
            }
            else
            {
                Console.WriteLine("No node with data {0} found in CustomLinkedList", data);
            }
        }

        public void RemoveFirst()
        {
            if (head == null)
            {
                 Console.WriteLine("\nlinkedlist is empty");
            }
            else
            {
                int deletedNode = head.data;
                head = head.next;
                Console.WriteLine("\n{0} is delated from linkedlist", deletedNode);

            }
        }

        public void RemoveLast()
        {
            if( head == null)
                Console.WriteLine("\nlinkedlist is empty");
            else if (head.next == null)
            {
                Console.WriteLine("\n{0} is removed from last", head.data);
                head = head.next;
            }
            else
            {
                Node temp = head;
                while(temp.next.next != null)
                {
                    temp = temp.next;
                }
                Console.WriteLine("\n{0} is removed from last", temp.next.data);
                temp.next = null;

            }
        }

        public void Search(int input)
        {
            bool isPresent = false;
            if(head !=  null)
            {
                Node temp=head;
                while(temp!=null)
                {
                    if (temp.data == input)
                    {
                        isPresent = true;
                        Console.WriteLine("\n{0} is present in linkedlist", input);
                        break;
                    }
                    else
                    {
                        temp = temp.next;
                    }
                }
                if(!isPresent)
                {
                    Console.WriteLine("\n{0} is not present in linkedlist", input);
                }
            }
        }

        public void InsertBetween(int firstData, int secondData, int newData)
        {
            Node newNode = new Node(newData);
            Node currentNode = head;
            while (currentNode != null && currentNode.next != null && (currentNode.data != firstData || currentNode.next.data != secondData))
            {
                currentNode = currentNode.next;
            }
            if (currentNode != null && currentNode.next != null)
            {
                newNode.next = currentNode.next;
                currentNode.next = newNode;
                Console.WriteLine("{0} is inserted into CustomLinkedList between {1} and {2}", newData, firstData, secondData);
            }
            else
            {
                Console.WriteLine("No consecutive nodes with data {0} and {1} found in CustomLinkedList", firstData, secondData);
            }
        }

        public void DeleteInBetween(int data)
        {
            Node newNode = new Node(data);
            Node currentNode = head;
            if (head == null)
            {
                Console.WriteLine("No data is present in linkedlist");
            }
            if(head.data == data)
            {
                head = head.next;
                Console.WriteLine("{0} is deleted from list", data);
                Console.WriteLine("{0} size of linked list is:", Size());
            }
            Node previousNode = FindPreviousNode(data);
            if(previousNode !=null && previousNode.next != null)
            {
                newNode.next = currentNode.next;
                currentNode.next = newNode;
                Console.WriteLine("\n{0} is added in linkedlist", data);
                Console.WriteLine("size of linked list is: {0}", Size());
            }
        }

        //Method to search for a previous of a node with specified data and return it
        private Node FindPreviousNode(int data)
        {
            Node currentNode = head;
           while(currentNode != null)
            {
                if (currentNode.next != null && currentNode.next.data == data)
                {
                    return currentNode;
                }
                else
                {
                    currentNode = currentNode.next;
                }
            }
            return null;
        }

        //Method to return the size if the list
        public int Size()
        {
            int size = 0;
            Node currentNode = head;
            while(currentNode != null)
            {
                size++;
                currentNode = currentNode.next;

            }
            return size;
        }


    }
}

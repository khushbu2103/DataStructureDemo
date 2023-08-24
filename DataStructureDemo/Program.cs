using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the data structure programs");
            Console.WriteLine("please choose any program");
            Console.WriteLine("1.Buit-in LinkedList\n2.Custom LinkedList\n3.Sorted custom linkedlist\n4.Built in stack\n5.Linkedlist stack");
            int option = Convert.ToInt32(Console.ReadLine());

            switch(option)
            {
                case 1:
                    LinkedList<int> li = new LinkedList<int>();
                    li.AddLast(10);
                    li.AddLast(20);
                    li.AddLast(30);

                    foreach(int data in li)
                    {
                        Console.Write(data+" ");
                    }

                    li.AddFirst(40);
                    Console.WriteLine();
                    foreach(int data in li)
                    {
                        Console.Write(data+" ");
                    }
                    break;
                case 2:
                    CustomLinkedList customLinkedList = new CustomLinkedList();
                    customLinkedList.Append(56);
                    customLinkedList.Append(70);
                    customLinkedList.InsertAfter(56, 30);
                    customLinkedList.Display();
                    //customLinkedList.RemoveLast();
                    //customLinkedList.Display();
                    customLinkedList.Search(30);
                    customLinkedList.InsertBetween(30, 70, 40);
                    customLinkedList.Display();
                    customLinkedList.DeleteInBetween(40);
                    customLinkedList.Display();
                    
                    break;
                case 3:
                    Sorted sortedList = new Sorted();
                    sortedList.Add(56);
                    sortedList.Add(30);
                    sortedList.Add(40);
                    sortedList.Add(70);
                    Console.WriteLine("Sorted linked list:");
                    sortedList.Display();
                    break;
                case 4:
                    Stack<int> stack = new Stack<int>();
                    stack.Push(70);
                    stack.Push(30);
                    stack.Push(56);
                    foreach(int data in stack)
                    {
                        Console.Write(data + " ");
                    }
                    break;

                   //Stack programs
                case 5:
                    LinkedListStack linkedListStack = new LinkedListStack();
                    linkedListStack.Push(70);
                    linkedListStack.Push(30);
                    linkedListStack.Push(56);
                    linkedListStack.Display();
                    break;
            }
            
            Console.ReadLine();
        }
    }
}

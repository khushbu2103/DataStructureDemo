﻿using System;
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
            Console.WriteLine("1.Buit-in LinkedList\n2.Custom LinkedList");
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
                    //customLinkedList.InsertBetween(30, 70, 40);
                    //customLinkedList.Display();
                    Console.WriteLine("\nEnter data of the first node:");
                    int firstData = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter data of the second node:");
                    int secondData = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter data of the new node:");
                    int newData = Convert.ToInt32(Console.ReadLine());
                    customLinkedList.InsertBetween(firstData, secondData, newData);
                    customLinkedList.Display();
                   
                    break;
            }
            Console.ReadLine();
        }
    }
}

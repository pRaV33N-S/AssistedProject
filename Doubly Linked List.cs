﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssistedProject
{
    internal class Doubly_Linked_List
    {
        static void Main(string[] args)
        {
            runApp();
        }

        public static void runApp()
        {
            DoublyLinkedList list = new DoublyLinkedList();
            DoublyNode n = new DoublyNode();
            n.Data = "root";
            list.add(n);
            for (int i = 0; i < 10; i++)
            {
                DoublyNode node = new DoublyNode();
                node.Data = Convert.ToString(i);
                list.add(node);
            }

            Console.WriteLine("length of singly linked list=" + list.getLengthOfList());
            Console.WriteLine("Traversing forward..");
            n = list.getRoot();
            while (n != null)
            {
                Console.WriteLine(n.Data);
                n = list.getNext();
            }


            Console.WriteLine("Traversing backwards..");
            n = list.getPrev();
            while (n != null)
            {
                Console.WriteLine(n.Data);
                n = list.getPrev();
            }

        }
    }

}

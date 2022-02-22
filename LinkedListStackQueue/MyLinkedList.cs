using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListStackQueue
{
    public class MyLinkedList
    {
        public static void Run()
        {
            SeunLinkedList<int> num = new SeunLinkedList<int>();
            SeunLinkedList<string> letters = new SeunLinkedList<string>();
            num.AddToFront(1);
            num.AddToFront(2);
            num.AddToFront(5);
            num.AddToFront(4);
            num.AddToFront(53);
            num.AddToFront(53);
            num.AddToFront(53);

            num.Show(0);
            Console.WriteLine();
            num.AddToBack(132);
            num.AddToBack(123);
            num.Show(1);
        }
    }
}

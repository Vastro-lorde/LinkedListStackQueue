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
            num.AddToBack(23);
            num.AddToBack(68);
            num.AddToBack(48);
            num.AddToBack(8);
            num.AddToFront(10);
            num.AddToFront(13);
            Console.WriteLine(num.Check(23));
            Console.WriteLine(num.Index(10));
            Console.WriteLine(num.GetCount());
            num.Show();

            Sstack<int> seunstack = new Sstack<int>();
            Console.WriteLine(seunstack.Peek());
            seunstack.Push(2342);
            seunstack.Push(65);
            seunstack.Push(2);
            seunstack.Push(6543);
            seunstack.Push(78);
            seunstack.Push(65); 
            seunstack.Print();
            Console.WriteLine(seunstack.Pop());
            seunstack.Print();
            Console.WriteLine(seunstack.Size());
            Console.WriteLine(seunstack.Peek());

        }
    }
}

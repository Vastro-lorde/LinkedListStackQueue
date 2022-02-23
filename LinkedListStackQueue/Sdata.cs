using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListStackQueue
{
    public class Sdata
    {
        public static void Run()
        {
            SLinkedList<int> num = new SLinkedList<int>();
            SLinkedList<string> letters = new SLinkedList<string>();
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

            Sstack<int> seunStack = new Sstack<int>();
            seunStack.Push(2342);
            seunStack.Push(65);
            seunStack.Push(2);
            seunStack.Push(6543);
            seunStack.Push(78);
            seunStack.Push(65);
            seunStack.Print();
            Console.WriteLine(seunStack.Pop());
            seunStack.Print();
            Console.WriteLine(seunStack.Size());
            Console.WriteLine(seunStack.Peek());

            Squeue<string> sQueue = new Squeue<string>();
            sQueue.Enqueue("1");
            sQueue.Enqueue("seun");
            sQueue.Enqueue("2");
            sQueue.Enqueue("3");
            sQueue.Print();
            sQueue.Dequeue();
            sQueue.Print();
            sQueue.Enqueue("1");
            sQueue.Print();
            Console.WriteLine(sQueue.Size());
        }
    }
}

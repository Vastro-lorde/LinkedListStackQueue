using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListStackQueue
{
    internal class Squeue<T>
    {
        // Constructor and property
        public SLinkedList<T> sQueue;
        public Squeue() {
            sQueue = new SLinkedList<T>(); 
        }
        // Methods
        public void Enqueue(T data) => sQueue.AddToBack(data);
        public void Dequeue() => sQueue.Remove(sQueue.head.data);
        public void Print() => sQueue.Show();
        public bool IsEmpty() => sQueue.IsEmpty();
        public int Size() => sQueue.count;
    }
}

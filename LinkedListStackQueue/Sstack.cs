using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListStackQueue
{
    class Sstack<T>
    {
        public SLinkedList<T> sStack;

        public Sstack() { sStack = new SLinkedList<T>(); }
        public void Push(T data) => sStack.AddToFront(data);
        public T Pop()
        {
            var deleted = sStack.head.data;
            sStack.Remove(sStack.head.data);
            return deleted;
        }
        public object Peek()
        {
            if (sStack.head == null) throw new Exception("Empty List");
            return sStack.head.data;
        }
        public bool IsEmpty() => sStack.IsEmpty();
        public int Size() => sStack.count;
        public void Print() => sStack.Show();
    }
}

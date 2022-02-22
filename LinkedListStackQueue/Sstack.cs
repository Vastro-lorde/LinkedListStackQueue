using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListStackQueue
{
    class Sstack<T>
    {
        private Snode<T> head;
        public int count;

        public Sstack() { head = null; }
        public int Size() { return count; }
        public  void Push(T data)
        {
            Snode<T> newNode = new Snode<T>(data);

            if (head == null)
            {
                head = newNode;
                return;
            }
            Snode<T> temp = head;
            head = newNode;
            head.next = temp;
            count++;
        }
        public object Pop()
        {
            if (head == null) return null;
            var temp = head;
            head = head.next;
            count--;
            return temp.data;
        }

        public object Peek()
        {
            if (head == null)
            {
                return null;
            }
            return head.data;
        }

        public bool IsEmpty()
        {
            if (head == null)
            {
                return true;
            }
            return false;
        }
        public void Print()
        {
            Snode<T> seunNode = head;
            Console.Write("[");
            while (seunNode != null)
            {
                Console.Write($"{seunNode.data},");
                seunNode = seunNode.next;
            }
            Console.Write("]");
        }
    }
}

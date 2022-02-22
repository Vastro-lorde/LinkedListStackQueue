using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListStackQueue
{
    internal class Squeue<T>
    {
        private Snode<T> head;
        public int count;

        public Squeue() { head = null; }
        public int Size() { return count; }

        public void Enqueue(T data)
        {
            Snode<T> newNode = new Snode<T>(data);

            if (head == null)
            {
                head = newNode;
                return;
            }

            Snode<T> temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = newNode;

            count++;
        }

        public void Dequeue()
        {
            if (head == null) return;
            var tempNode = head.next;
            var formerNode = head;
            head = tempNode;
            count--;
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
        public bool IsEmpty()
        {
            if (head == null)
            {
                return true;
            }
            return false;
        }
    }
}

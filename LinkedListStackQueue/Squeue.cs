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
    }
}

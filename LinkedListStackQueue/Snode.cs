using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListStackQueue
{
    public class Snode<T>
    {
        public T data;
        public Snode<T> next;

        public Snode(T data)
        {
            this.data = data;
            next = null;
        }
        /*public object getValue() { return data; }
        public void setValue(int value) { this.data = value; }
        public SeunNode getNext() { return next; }
        public void setNext(SeunNode next) { this.next = next; }*/
      
    }
}

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
      
    }
}

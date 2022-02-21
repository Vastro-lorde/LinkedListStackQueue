using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListStackQueue
{

    public class SeunLinkedList<T>
    {
        private Snode<T> head;
        private Snode<T> tail;
        public int count;

        public SeunLinkedList() { head = null; }
        public int GetCount() { return count; }

        public bool IsNull(T data) { bool result = data == null ? true : false;  return result; }
        
        public bool Remove(T data)
        {
            if (IsNull(head.data)) return false;
            var tempNode = head.next;
            var formerNode = head;
            if (head.data.Equals(data))
            {
                head = tempNode;
                count--;
                return true;
            }
            while (!IsNull(tempNode.data))
            {
                if (tempNode.data.Equals(data))
                {

                }
            }
            count--;
            return false;
        }

        // Adds data to the end => Push();
        public void AddToFront(T data)
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

        public void AddToBack(T data)
        {
            Snode<T> newNode = new Snode<T>(data);

            if (tail == null)
            {
                tail = newNode;
                return;
            }

            Snode<T> temp = tail;
            while (temp.next != null)
            {
               temp = temp.next;
            }
            temp.next = newNode;
            
            count++;
        }

        //  gets the index of the data in the linked list
        public int Index(T data)
        {
            
            int index = 0;
            if (!IsNull(head.data))
            {
                var sTempH = head;
                var sTempN = head.next;
                index++;
                if (sTempH.data.Equals(data)) return 0;
                while (!IsNull(sTempN.data))
                {
                    if (sTempN.data.Equals(data)) return index;
                    sTempH = sTempN;
                    sTempN = sTempH.next;
                    index++;
                }

            }
            return index;
        }

        public void PrintForward()
        {
            Snode<T> seunNode = tail;
            while (seunNode != null)
            {
                Console.Write($"{seunNode.data},");
                seunNode = seunNode.next;
            }
        }

        public void PrintBackward()
        {
            Snode<T> seunNode = head;
            while (seunNode != null)
            {
                Console.Write($"{seunNode.data},");
                seunNode = seunNode.next;
            }
        }
        // Prints all SeunNode data out in console with {}.
        public void Show()
        {
            Console.Write("[");
            PrintBackward();
            Console.Write("]");
        }
    }
    public class MyLinkedList
    {
        public static void Run()
        {
            SeunLinkedList<object> num = new SeunLinkedList<object>();
            SeunLinkedList<string> letters = new SeunLinkedList<string>();
            num.AddToFront(1);
            num.AddToFront(2);
            num.AddToFront(5);
            num.AddToFront(4);
            num.AddToFront("nawa");
            num.AddToFront(53);
            num.AddToFront(53);
            num.AddToFront(53);
            num.Show();
            Console.WriteLine(num.Index("nawa"));
        }
    }
}

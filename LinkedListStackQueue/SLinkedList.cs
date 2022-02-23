using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListStackQueue
{

    public class SLinkedList<T>
    {
        public Snode<T> head;
        public int count;

        public SLinkedList() { head = null; }
        public int GetCount() { return count; }

        public bool IsNull(Snode<T> data) { bool result = data == null ? true : false;  return result; }
        
        public bool Remove(T data)
        {
            if (IsNull(head)) return false;
            var tempNode = head.next;
            var formerNode = head;
            if (head.data.Equals(data))
            {
                head = tempNode;
                count--;
                return true;
            }
            while (!IsNull(tempNode))
            {
                if (tempNode.data.Equals(data))
                {
                    formerNode.next = tempNode.next;
                    count--;
                    return true;
                }
                formerNode = tempNode;
                tempNode = tempNode.next;
            }
            return false;
        }

        // Adds data to the end => Push();
        public int AddToFront(T data)
        {
            Snode<T> newNode = new Snode<T>(data);

            if (head == null)
            {
                head = newNode;
                return 0;
            }
            Snode<T> temp = head;
            head = newNode;
            head.next = temp;
            count++;
            return count;
        }

        public int AddToBack(T data)
        {
            Snode<T> newNode = new Snode<T>(data);

            if (head == null)
            {
                head = newNode;
                return 0;
            }

            Snode<T> temp = head;
            while (temp.next != null)
            {
               temp = temp.next;
            }
            temp.next = newNode;
            
            return count++;
        }

        public bool Check(T data)
        {
            if (head != null)
            {
                if (head.Equals(data))
                {
                    return true;
                }
                Snode<T> sTemp = head;
                while (sTemp != null)
                {
                    if (sTemp.data.Equals(data))
                    {
                        return true;
                    }
                    sTemp = sTemp.next;
                }
            }
            return false;
        }

        //  gets the index of the data in the linked list
        public int Index(T data)
        {
            
            int index = 0;
            if (!IsNull(head))
            {
                var sTempH = head;
                var sTempN = head.next;
                index++;
                if (sTempH.data.Equals(data)) return 0;
                while (!IsNull(sTempN))
                {
                    if (sTempN.data.Equals(data)) return index;
                    sTempH = sTempN;
                    sTempN = sTempH.next;
                    index++;
                }

            }
            return index;
        }
        public bool IsEmpty()
        {
            if (head == null)
            {
                return true;
            }
            return false;
        }
        // Prints each 
        public void Print()
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
                Print();
                Console.Write("]");
        }
    }
}

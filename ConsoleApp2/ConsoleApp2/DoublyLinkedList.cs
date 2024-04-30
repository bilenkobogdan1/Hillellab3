using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class DoublyNode
    {
        public DoublyNode(object data)
        {
            Data = data;
        }
        public object Data { get; set; }
        public DoublyNode Previous { get; set; }
        public DoublyNode Next { get; set; }
    }
    public class DoublyLinkedList : IEnumerable  
    {
        private DoublyNode head; 
        private DoublyNode tail; 

        public DoublyNode First
        {
            get { return head; }
            set { head = value; }
        }
        public DoublyNode Last
        {
            get { return tail; }
            set { tail = value; }
        }
        int count;  

    
        public void Add(object data)
        {
            DoublyNode node = new DoublyNode(data);

            if (head == null)
                head = node;
            else
            {
                tail.Next = node;
                node.Previous = tail;
            }
            tail = node;
            count++;
        }
        public void AddFirst(object data)
        {
            DoublyNode node = new DoublyNode(data);
            DoublyNode temp = head;
            node.Next = temp;
            head = node;
            if (count == 0)
                tail = head;
            else
                temp.Previous = node;
            count++;
        }
        public bool Remove(object data)
        {
            DoublyNode current = head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    break;
                }
                current = current.Next;
            }
            if (current != null)
            {
                if (current.Next != null)
                {
                    current.Next.Previous = current.Previous;
                }
                else
                {
                    tail = current.Previous;
                }

                if (current.Previous != null)
                {
                    current.Previous.Next = current.Next;
                }
                else
                {
                    head = current.Next;
                }
                count--;
                return true;
            }
            return false;
        }

        public void RemoveFirst()
        {
            if (head != null)
            {
                head = head.Next;
            }
        }
        public void RemoveLast()
        {
            if (tail != null)
            {
                tail = tail.Previous;
            }
        }

        public int Count { get { return count; } }

        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public bool Contains(object data)
        {
            DoublyNode current = head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                    return true;
                current = current.Next;
            }
            return false;
        }
        object[] ToArray()
        {
            DoublyNode current = head;
            List<object> listObject = new List<object>();
            while (current != null && current.Data != null)
            {
                listObject.Add(current.Data);
                current = current.Next;
            }
            return listObject.ToArray();
        }
       

        IEnumerator IEnumerable.GetEnumerator()
        {
            DoublyNode current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }



    }
}

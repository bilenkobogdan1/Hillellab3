using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Node
    {
        public Node(object data)
        {
            Data = data;
        }
        public object Data { get; set; }
        public Node Next { get; set; }
    }

    public class LinkedList : IEnumerable
    {
        private Node head;
        private Node tail;
        public Node First
        {
            get { return head; }
            set { head = value; }
        }

        public Node Last
        {
            get { return tail; }
            set { tail = value; }
        }

        int count;


        public void Add(object data)
        {
            Node node = new Node(data);

            if (head == null)
                head = node;
            else
                tail!.Next = node;
            tail = node;

            count++;
        }

        public bool Remove(object data)
        {
            Node current = head;
            Node previous = null;

            while (current != null && current.Data != null)
            {
                if (current.Data.Equals(data))
                {

                    if (previous != null)
                    {

                        previous.Next = current.Next;


                        if (current.Next == null)
                            tail = previous;
                    }
                    else
                    {

                        head = head?.Next;


                        if (head == null)
                            tail = null;
                    }
                    count--;
                    return true;
                }

                previous = current;
                current = current.Next;
            }
            return false;
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
            Node current = head;
            while (current != null && current.Data != null)
            {
                if (current.Data.Equals(data)) return true;
                current = current.Next;
            }
            return false;
        }
        public void AddFirst(object data)
        {
            Node node = new Node(data);
            node.Next = head;
            head = node;
            if (count == 0)
                tail = head;
            count++;
        }
        object[] ToArray()
        {
            Node current = head;
            List<object> listObject = new List<object>();
            while (current != null && current.Data != null)
            {
                listObject.Add(current.Data);
                current = current.Next;
            }
            return listObject.ToArray();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}

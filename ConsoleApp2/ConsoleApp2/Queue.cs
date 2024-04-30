using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class NodeQ
    {
        public NodeQ(object data)
        {
            Data = data;
        }
        public object Data { get; set; }
        public NodeQ Next { get; set; }
    }
    public class Queue : IEnumerable
    {
        NodeQ head; 
        NodeQ tail; 
        int count;
        public void Enqueue(object data)
        {
            NodeQ node = new NodeQ(data);
            NodeQ tempNode = tail;
            tail = node;
            if (count == 0)
                head = tail;
            else
                tempNode.Next = tail;
            count++;
        }
        public object Dequeue()
        {
            if (count == 0)
                throw new InvalidOperationException();
            object output = head.Data;
            head = head.Next;
            count--;
            return output;
        }
        public object Peek() => head.Data;

   
        public int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }

        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public bool Contains(object data)
        {
            NodeQ current = head;
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
            NodeQ current = head;
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
            NodeQ current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}

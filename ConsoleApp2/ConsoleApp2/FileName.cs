using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class FileName
    {
        public static void Main(string[] args)
        {
            //ComplexNumber
            /* ComplexNumber<decimal> complexNumber1 = new ComplexNumber<decimal>(4.4m,2m);
             ComplexNumber<decimal> complexNumber2 = new ComplexNumber<decimal>(2.1m, 0.3m);
             var result = complexNumber1 - complexNumber2;
             result.Print();*/

            //Point
            /*
            Point p = new Point(0, 0);
            p.x = 5;
            p.Print();
            */
            //List
            /*
            ListTest ff = new ListTest() { "hello", "world" };
            Console.WriteLine(ff.Count);
            ff.Insert(0, "hello ukraine");
            Console.WriteLine(ff[2]);
            Console.WriteLine(ff.Count);
            */

            //LinkedList
            /*
            LinkedList linkedList = new LinkedList{ "Tom", "Alice", "Bob","Sam"};
            linkedList.Remove("Alice");
            Console.WriteLine("После удаления Alice");
            bool isPresent = linkedList.Contains("Alice");
            Console.WriteLine(isPresent ? "Sam присутствует" : "Sam отсутствует");
            */

            //DoublyLinkedList
            /*
            DoublyLinkedList linkedList = new DoublyLinkedList() { "Bob", "Bill" };
            linkedList.Add("Tom");
            linkedList.AddFirst("Kate");
            linkedList.Remove("Bill");    
            foreach (var t in linkedList)
            {
                Console.WriteLine(t);
            }
            */

            //Queue
            /*
            Queue queue = new Queue();
            queue.Enqueue("Kate");
            queue.Enqueue("Sam");
            queue.Enqueue("Alice");
            queue.Enqueue("Tom");

            foreach (string item in queue)
                Console.WriteLine(item);
            Console.WriteLine();

            Console.WriteLine();
            object firstItem = queue.Dequeue();
            Console.WriteLine($"Dequeue: {firstItem}");
            Console.WriteLine();

            foreach (string item in queue)
                Console.WriteLine(item);
            */

        }
    }
}

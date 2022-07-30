using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace hashTable_demo
{
    class Program
    {
        static void Main(string[] args)
        { 
            Hashtable h = new Hashtable();                            //hashTable    //uses key/value
            h.Add("Id", 12);
            h.Add("Name", "Priya");
            h.Add("Salary", 15000.00);

            h.Remove("Salary");                           // to remove element

            Console.WriteLine(h["Id"]);

            foreach (object key in h.Keys)               //to access values
            {
                Console.WriteLine(h[key]);

            }

            Console.WriteLine("------------------------stack-------------------------------------------------");

            Stack st = new Stack();                         //stack in non generic   //uses LIFO
            st.Push("Priya");
            st.Push("Survase");
            st.Push(10);
            st.Push(12.22);


            foreach (object obj in st)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("-----------------------------------------------------");

            st.Pop();                     //removes the last element inserted first

            foreach (object obj in st)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("--------------------Queue----------------------------------");

            Queue q = new Queue();                                     //uses FIFO
            q.Enqueue("ABC");
            q.Enqueue(2000);
            q.Enqueue('A');
            q.Enqueue(100.200);

            /*foreach (object item in q)
            {
                Console.WriteLine(item);
            }*/

            q.Dequeue();                              //in queue it removes the first element first

            foreach (object item in q)
            {
                Console.WriteLine(item);
            }

        }
    }
}

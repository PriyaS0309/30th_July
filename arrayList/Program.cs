using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace arrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myList = new ArrayList();                               
            myList.Add(10);
            myList.Add("Priya");
            myList.Add(10.20);
            myList.Add('A');
            
            Console.WriteLine(myList.Capacity);

            
            

            foreach (object obj in myList)
            {
                Console.Write(obj + "    ");
            }
             Console.WriteLine();

            myList.Insert(2, "Survase");
            foreach (object obj in myList)
            {
                Console.Write(obj + "    ");
            }
            Console.WriteLine();

            myList.Remove("Survase");
            foreach (object obj in myList)
            {
                Console.Write(obj + "    ");
            }
            Console.WriteLine();

        }
        
                            
    }
}

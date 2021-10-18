using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_MultiThreading
{
    class Myclass
    {
        public void Display()
        {
            Console.WriteLine("Implementing thread 1");

            for(int i=0;i<100;i++)
            {
                Console.WriteLine("\n {0}", i);
            }
            Console.WriteLine("Thread 1 Closes");
        }
        public void Read()
        {
            Console.WriteLine("Implementing thread2...");
            for (char j = 'A';j< 'Z';j++)
                {
                Console.WriteLine(j);
            }
            Console.WriteLine("Thread 2 Closes");
        }
    }
}

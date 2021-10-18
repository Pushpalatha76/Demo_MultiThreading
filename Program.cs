using System;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using System.Text;

namespace Demo_MultiThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implementing Multitsking and MultiThreading in csharp!");
            Myclass History = new Myclass();
            Console.WriteLine("Main Thread Started.....");
            History.Display();

            ThreadStart th1 = History.Display;
            ThreadStart th2 = History.Read;
            Thread s1 = new Thread(th1);
            Thread s2 = new Thread(th2);
            
            s1.Start();
            s2.Start();

            Console.WriteLine("Main Threads ends Here...!!!!");
            Console.ReadKey();

            
        }
    }
}

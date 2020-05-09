using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultithreadingBasic
{
    class SimpleThread
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(ThreadStartFunction);
            t1.Start();
            Console.WriteLine("Started the thread..!");
        }
        static void ThreadStartFunction()
        {
            for (int cnt = 0; cnt < 10; cnt++)
            {
                Console.WriteLine($"count:{cnt}");
                Thread.Sleep(1000);
            }

        }
    }
}

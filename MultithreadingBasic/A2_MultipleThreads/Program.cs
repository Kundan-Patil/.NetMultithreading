using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SimpleThread___1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(ThreadStartFunction);
            t1.Name = "Eina";

            Thread t2 = new Thread(ThreadStartFunction);
            t2.Name = "Mina";

            Thread t3 = new Thread(ThreadStartFunction);
            t3.Name = "Diga";

            t1.Start();
            t2.Start();
            t3.Start();

            Console.WriteLine("Started all threads..!");
        }

        static void ThreadStartFunction()
        {
            for (int cnt = 0; cnt < 5; cnt++)
            {
                Console.WriteLine($"count:{cnt} , Thread:{Thread.CurrentThread.Name}");
                Thread.Sleep(1000);
            }
        }
    }
}

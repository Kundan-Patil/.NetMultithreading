using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace A5_SynchronizationUsingMutex
{
    class Program
    {
        static Mutex myMutex = new Mutex();
        static void Main(string[] args)
        {
            Thread ping = new Thread(PerformTask);
            Thread pong = new Thread(PerformTask);
            ping.Name = "Ping";
            pong.Name = "Pong";
            ping.Start();
            pong.Start();
        }

        static void PerformTask()
        {
            #region : Example from session for Mutex
            ////Acquire mutex
            //myMutex.WaitOne();

            //Console.WriteLine($"I am {Thread.CurrentThread.Name} Started");
            //Thread.Sleep(3000);
            //Console.WriteLine($"I am {Thread.CurrentThread.Name} Stopped");

            ////Release mutex
            //myMutex.ReleaseMutex();
            #endregion : Example from session for Mutex

            #region : Example for Synchronization using Mutex
            for (int i = 0; i < 5; i++)
            {
                myMutex.WaitOne();
                Console.WriteLine($"I am {Thread.CurrentThread.Name}");
                Thread.Sleep(3000);
                myMutex.ReleaseMutex();
            }
            #endregion : Example for Synchronization using Mutex

        }
    }
}

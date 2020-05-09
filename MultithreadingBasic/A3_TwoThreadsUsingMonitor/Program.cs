using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace A3_ThreadsUsingMonitor
{
    class Program
    {
        static object myLock = new object();
        static void Main(string[] args)
        {
            Thread ping = new Thread(TakeTurns);
            Thread pong = new Thread(TakeTurns);
            ping.Name = "Ping";
            pong.Name = "Pong";
            ping.Start();
            pong.Start();
        }

        static void TakeTurns()
        {
            //Enters critical section
            Monitor.Enter(myLock);

            Console.WriteLine($"{Thread.CurrentThread.Name} Started");
            Thread.Sleep(5000);
            Console.WriteLine($"{Thread.CurrentThread.Name} Stopped");

            //Leave critical section
            Monitor.Exit(myLock);
        }
    }
}

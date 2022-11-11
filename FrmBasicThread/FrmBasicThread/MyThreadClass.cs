using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FrmBasicThread
{
    internal class MyThreadClass
    {
        public void thread1()
        {
            for (int LoopCount = 0; LoopCount <= 2; LoopCount++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of the thread : " + thread.Name + " = " + LoopCount);
                Thread.Sleep(TimeSpan.FromSeconds(0.3));
            }
        }

        public void thread2()
        {
            for (int LoopCount = 0; LoopCount <= 5; LoopCount++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of the thread : " + thread.Name + " = " + LoopCount);
                Thread.Sleep(TimeSpan.FromSeconds(1.5));
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CSharpTutorial
{
    class DeadLock
    {
        //Definition : is a situation where an application locks up because two or more activities are waiting for each other to finish.
        //This occurs in multithreading software where a shared resource is locked by one thread and another thread is waiting to access it
        //and something occurs so that the thread holding the locked item is waiting for the other thread to execute.

        static readonly object firstLock = new object();
        static readonly object secondLock = new object();
        static void ThreadJob()
        {
            Console.WriteLine("\t\t\t\tLocking firstLock");
            lock (firstLock)
            {
                Console.WriteLine("\t\t\t\tLocked firstLock");
                // Wait until we're fairly sure the first thread
                // has grabbed secondLock
                Thread.Sleep(1000);
                Console.WriteLine("\t\t\t\tLocking secondLock");
                lock (secondLock)
                {
                    Console.WriteLine("\t\t\t\tLocked secondLock");
                }
                Console.WriteLine("\t\t\t\tReleased secondLock");
            }
            Console.WriteLine("\t\t\t\tReleased firstLock");
        }
        public void showExample()
        {
            new Thread(new ThreadStart(ThreadJob)).Start();
            // Wait until we're fairly sure the other thread
            // has grabbed firstLock
            Thread.Sleep(500);
            Console.WriteLine("Locking secondLock");
            lock (secondLock)
            {
                Console.WriteLine("Locked secondLock");
                Console.WriteLine("Locking firstLock");
                lock (firstLock)
                {
                    Console.WriteLine("Locked firstLock");
                }
                Console.WriteLine("Released firstLock");
            }
            Console.WriteLine("Released secondLock");
            Console.Read();
        }
    }
}



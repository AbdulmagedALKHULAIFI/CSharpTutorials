using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CSharpTutorial
{
    class MultiThread
    {
        public static void WriteB()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.Write('B');

                Thread.Sleep(100);
            }
        }

        public void showExample()
        {
            // Crée un Thread enfant, qui s'exécute en parallèle avec le Thread principal.
            Console.WriteLine("Create new Thread...\n");
            Thread newThread = new Thread(WriteB);

            Console.WriteLine("Start newThread...\n");
            newThread.Start();


            // Dans le thread principal, imprimez le caractère '-'
            Console.WriteLine("Call Write('-') in main Thread...\n");
            for (int i = 0; i < 50; i++)
            {
                Console.Write('-');
                // Dormez (sleep) 70 millisecondes.
                Thread.Sleep(70);
            }
            Console.WriteLine("Main Thread finished!\n");
            Console.Read();
        }
    }
}

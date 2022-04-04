using CSharpTutorial.Algos;
using CSharpTutorial.Collections;
using System;
using System.Collections.Generic;

namespace CSharpTutorial
{
    class Program
    {

       
        static void Main(string[] args)
        {


            LinkedListSwapper swapper = new LinkedListSwapper();

            ListNode nodes = swapper.CreateLinkedListFromList(new List<int>() { 7, 9, 6, 6, 7, 8, 3, 0, 9, 5 });

            // ------------------------------------------

            // Polymorphisme Example
            //PolymorphismeExample pl = new PolymorphismeExample();
            //pl.ShowExample();

            // HashSet example 
            //HashSetExample hs = new HashSetExample();
            //hs.showExample();

            //Generic example 
            //Generic<int> g = new Generic<int>();
            //g.showExample();

            //Delegate example
            //Delegate d = new Delegate();
            //d.showExample();

            //Multithread example
            //MultiThread mt = new MultiThread();
            //mt.showExample();

            //Deadlock example
            //DeadLock dl = new DeadLock();
            //dl.showExample();

            //Collections example
            //ListExample list = new ListExample();
            //list.showExample();
        }
    }
}

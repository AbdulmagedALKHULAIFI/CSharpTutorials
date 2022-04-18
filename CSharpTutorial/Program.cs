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


            AlgosReslover resolver = new AlgosReslover();

            string result = resolver.ZigZagConverter("PAYPALISHIRING", 3);

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

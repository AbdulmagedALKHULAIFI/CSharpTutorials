using System;

namespace CSharpTutorial
{
    class Program
    {
        static void Main(string[] args)
        {

            //Generic example 
            //Generic<int> g = new Generic<int>();
            //g.showExample();

            //Delegate example
            //Delegate d = new Delegate();
            //d.showExample();

            //Multithread example
            MultiThread mt = new MultiThread();
            mt.showExample();
        }
    }
}

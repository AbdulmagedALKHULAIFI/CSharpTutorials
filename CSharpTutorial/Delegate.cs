using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTutorial
{
    delegate int NumberChanger(int n);
    class Delegate
    {

        // Definition : C# delegates are similar to pointers to functions, in C or C++.
        // It is a variable that holds the reference to a method. The reference can be changed at runtime.
        static int num = 10;

        public static int AddNum(int p)
        {
            num += p;
            return num;
        }
        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }
        public static int getNum()
        {
            return num;
        }

        public void showExample()
        {
            NumberChanger nc;
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultNum);

            nc1(5);
            // 10 + 5 = 15
            Console.WriteLine("Value of Num: {0}", getNum());


            //calling multicast 
            nc = nc1;
            nc += nc2;

            nc(5);
            //it will add 5 and multiplie by 5 also
            // 100
            Console.WriteLine("Value of Num: {0}", getNum());



        }
    }
}

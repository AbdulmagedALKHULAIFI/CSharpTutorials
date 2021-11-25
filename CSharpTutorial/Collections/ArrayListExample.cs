using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CSharpTutorial.Collections
{
    class ArrayListExample
    {

        public void showExample()
        {
            DisplayArrayListExample();
        }
        void DisplayArrayListExample()
        {
            //unlike array you can add and remove items from a list at a specified position using an index
            //and the array resizes itself automatically.
            ArrayList items = new ArrayList();

            items.Add(1);
            items.Add("Hello");
            items.Add(true);
            items.Add(1.5);

            Console.WriteLine("Displaying ArrayList example ...\n");
            foreach (var item in items)
                Console.WriteLine(item);
        }
    }
}

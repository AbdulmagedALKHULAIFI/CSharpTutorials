using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTutorial
{
    class Generic<T>
    {
        List<T> items;

        public Generic()
        {
            items = new List<T>();
        }
        public void Add(T item) {
            items.Add(item);
        }

        public void displayItems()
        {
            foreach(var item in items)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n");
        }

        public void showExample()
        {

            Generic<int> list1 = new Generic<int>();
            list1.Add(1);
            list1.Add(1);
            list1.Add(1);
            list1.Add(1);

            list1.displayItems();

            // Declare a list of type string.
            Generic<string> list2 = new Generic<string>();
            list2.Add("a");
            list2.Add("a");
            list2.Add("a");
            list2.Add("a");
            list2.Add("a");

            list2.displayItems();
        }
    }
}

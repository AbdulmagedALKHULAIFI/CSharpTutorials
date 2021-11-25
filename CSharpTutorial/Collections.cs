﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpTutorial
{
    class Collections
    {
        public void showExample()
        {
            //DisplayArrayListExample();
            //VerifyItemInList(new List<int> { 1, 2, 6, 7 },2);
            VerifyItemInList(new List<string> { "a","b","c" }, "c");
            VerifyItemInList(new List<string> { "a", "b", "c" }, "f");
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

        void VerifyItemInList<T>(List<T> items,T item)
        {
            //verifiy if 3 is in the list
            bool itemExists = items.Any(x => x.Equals(item));

            if (itemExists)
                Console.WriteLine("The list contains {0}", item);
            else
                Console.WriteLine("The list does not contain {0}", item);
        }
    }
}

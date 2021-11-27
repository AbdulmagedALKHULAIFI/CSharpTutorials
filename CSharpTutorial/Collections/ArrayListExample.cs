using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CSharpTutorial.Collections
{
    class ArrayListExample : Icollection
    {
        ArrayList list1;
        ArrayList list2;
        ArrayList result;

        public ArrayListExample(ArrayList l1, ArrayList l2)
        {
            list1 = l1;
            list2 = l2;
        }

        public void showExample()
        {
            DisplayArrayListExample();
        }

        public void MergeTwoListsWithoutDuplicates()
        {
            //result = list1.Union(list2).ToArray(); 
        }
        public void SortList()
        {
            throw new NotImplementedException();
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

        public void GetUniqueItems()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CSharpTutorial.Collections
{
    public class ArrayListExample : Icollection
    {
        public ArrayList arrayList1;
        public ArrayList arrayList2;
        public ArrayList result;

        public ArrayListExample()
        {
            arrayList1 = new ArrayList();
            arrayList1 = new ArrayList();
            result = new ArrayList();
        }
        public ArrayListExample(ArrayList l1, ArrayList l2)
        {
            arrayList1 = l1;
            arrayList2 = l2;
        }

        public void showExample()
        {
            DisplayArrayListExample();
        }

        public void MergeTwoListsWithoutDuplicates()
        {
            //Add all items in first list 
            foreach(var item in arrayList1)
            {
                if (arrayList2.Contains(item))
                {
                    result.Add(item);
                    arrayList2.Remove(item);
                }
                else
                    result.Add(item);
            }

            //Add unique items from second list
            foreach (var item in arrayList2)
                result.Add(item);
        }

        public void SortList()
        {
            result.Sort() ;
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

using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTutorial.Collections
{
    class HashSetExample : Icollection
    {
        public void GetUniqueItems()
        {
            throw new NotImplementedException();
        }

        public void MergeTwoListsWithoutDuplicates()
        {
            throw new NotImplementedException();
        }

        public void showExample()
        {
            var hs = new HashSet<int>();
            hs.Add(1);
            hs.Add(2);
            hs.Add(3);
            hs.Add(3);

            Console.WriteLine(hs.Count);
        }

        public void SortList()
        {
            throw new NotImplementedException();
        }
    }
}

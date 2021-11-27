using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpTutorial.Collections 
{
    public class ListExample<T> : Icollection
    {
        public List<T> result;
        public List<T> list1;
        public List<T> list2;

        public ListExample()
        {
            //list1 = new List<T>[] { };
            //list2 = new List<T>[] { };
            //result = new List<T>[] { };
        }
        public void showExample()
        {
            VerifyItemInList(new List<int> { 1, 2, 6, 7 }, 2);
            VerifyItemInList(new List<string> { "a", "b", "c" }, "c");
            VerifyItemInList(new List<string> { "a", "b", "c" }, "f");
        }

        public void MergeTwoListsWithoutDuplicates()
        {
            list1.AddRange(list2);
        }
        public void SortList()
        {
            throw new NotImplementedException();
        }

        public bool VerifyItemInList<T>(List<T> items, T item) { return items.Any(x => x.Equals(item)); }

        public void GetUniqueItems()
        {
            throw new NotImplementedException();
        }
    }
}

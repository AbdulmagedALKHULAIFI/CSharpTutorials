using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpTutorial.Collections
{
    public class ListExample
    {

        public void showExample()
        {
            VerifyItemInList(new List<int> { 1, 2, 6, 7 }, 2);
            VerifyItemInList(new List<string> { "a", "b", "c" }, "c");
            VerifyItemInList(new List<string> { "a", "b", "c" }, "f");
        }

        public bool VerifyItemInList<T>(List<T> items, T item) { return items.Any(x => x.Equals(item)); }

    }
}

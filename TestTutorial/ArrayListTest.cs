using CSharpTutorial.Collections;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTutorial
{
    class ArrayListTest
    {
        ArrayListExample arrayList;

        [SetUp]
        public void setup()
        {
            arrayList = new ArrayListExample();
        }

        [Test]
        public void MergeTwoArraysWithoutDuplicate()
        {
            arrayList.arrayList1 = new ArrayList() { 1, 3, 5, 7, 9 };
            arrayList.arrayList2 = new ArrayList() { 2, 4, 6, 8, 9, 10 };

            arrayList.MergeTwoListsWithoutDuplicates();
            arrayList.result.Sort();

            Assert.AreEqual(arrayList.result,
                 new ArrayList() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
        }

    }
}

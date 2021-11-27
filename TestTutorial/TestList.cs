using NUnit.Framework;
using CSharpTutorial.Collections;
using System.Collections.Generic;
using System;

namespace TestTutorial
{
    public class Tests
    {
        ListExample <int> listInt;
        ListExample<string> listStr;
        [SetUp]
        public void Setup()
        {
            listInt = new ListExample <int>();
            listStr = new ListExample<string>();
        }

        [Test]
        public void VerifyItemInList()
        {
            Assert.IsTrue(listInt.VerifyItemInList(new List<int> { 1, 2, 6, 7 }, 2));
            Assert.IsTrue(listStr.VerifyItemInList(new List<string> { "a", "b", "c" }, "c"));
            Assert.IsFalse(listStr.VerifyItemInList(new List<string> { "a", "b", "c" }, "f"));
        }

        [Test]
        public void MergeTwoListWithoutDuplicate()
        {
            if (listInt.list1 != null && listInt.list1.Count > 0)
                listInt.list1.Clear();

            listInt.list1 = new List<int> { 1, 3, 5, 7, 9 };
            listInt.list2 = new List<int> { 2, 4, 6, 8, 9 , 10 };

            listInt.MergeTwoListsWithoutDuplicates();
            listInt.result.Sort();

            Assert.AreEqual(listInt.result,
                 new List<int> { 1, 2, 3, 4, 5,6 ,7,  8, 9, 10 });
        }
    }
}
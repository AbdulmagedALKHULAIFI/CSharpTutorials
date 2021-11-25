using NUnit.Framework;
using CSharpTutorial.Collections;
using System.Collections.Generic;

namespace TestTutorial
{
    public class Tests
    {
        ListExample list;
        [SetUp]
        public void Setup()
        {
            list = new ListExample();
        }

        [Test]
        public void VerifyItemInList()
        {
            Assert.IsTrue(list.VerifyItemInList(new List<int> { 1, 2, 6, 7 }, 2));
            Assert.IsTrue(list.VerifyItemInList(new List<string> { "a", "b", "c" }, "c"));
            Assert.IsFalse(list.VerifyItemInList(new List<string> { "a", "b", "c" }, "f"));
        }
    }
}
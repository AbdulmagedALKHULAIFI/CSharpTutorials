using CSharpTutorial.Algos;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTutorial
{
    class BoxesDistributorTest
    {
        BoxDistributor boxDistributor;

        [SetUp]
        public void setUp()
        {
            boxDistributor = new BoxDistributor();
        }

        [Test]
        public void DistributeBoxesTest()
        {
            int[] boxes;
            string result = string.Empty;

            boxes = new int[] { 3, 0, 0 };
            result = boxDistributor.solve(0, boxes, false);
            Assert.AreEqual("PICK|RIGHT|PUT|LEFT|PICK|RIGHT|RIGHT|PUT|"
                            , result);

            boxes = new int[] { 3, 0, 0 };
            result = boxDistributor.solve(3, boxes, false);
            Assert.AreEqual("LEFT|PICK|LEFT|LEFT|PUT|"
                            , result);

            boxes = new int[] { 2, 0, 0 };
            result = boxDistributor.solve(0, boxes, false);
            Assert.AreEqual("PICK|RIGHT|PUT|"
                , result);

            boxes = new int[] { 1, 0, 0 };
            result = boxDistributor.solve(0, boxes, false);
            Assert.AreEqual(""
                , result);

            boxes = new int[] { 1, 2, 7, 2 };
            result = boxDistributor.solve(0, boxes, false);
            Assert.AreEqual("RIGHT|RIGHT|PICK|LEFT|LEFT|PUT|RIGHT|RIGHT|PICK|LEFT|LEFT|PUT|RIGHT|RIGHT|PICK|LEFT|PUT|RIGHT|PICK|RIGHT|PUT|"
                , result);
        }
    }
}

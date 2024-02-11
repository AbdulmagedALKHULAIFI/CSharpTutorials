using CSharpTutorial.Algos;
using NUnit.Framework;

namespace TestTutorial.Algos
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


            boxes = new int[] { 1, 2, 7, 2 };
            result = boxDistributor.solve(0, boxes, false);
            Assert.AreEqual("RIGHT|RIGHT|PICK|LEFT|LEFT|PUT|RIGHT|RIGHT|PICK|LEFT|LEFT|PUT|RIGHT|RIGHT|PICK|LEFT|PUT|RIGHT|PICK|RIGHT|PUT|"
                , result);
        }
    }
}

using ar.codes.common_algos;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Shouldly;

namespace ar.codes.bubble_sort.test
{
    [TestClass]
    public class BinaryTreeTests
    {
        [TestMethod]
        public void AddNodeTest()
        {
            var bt = new BinaryTree<int>();

            bt.AddNode(5);
            bt.AddNode(4);
            bt.AddNode(6);
            bt.AddNode(1);

            bt.Root!.Value.ShouldBe(5);
            bt.Root!.Left!.Value.ShouldBe(4);
            bt.Root!.Right!.Value.ShouldBe(6);

            bt.Root!.Left!.Left!.Value.ShouldBe(1);
        }
    }
}
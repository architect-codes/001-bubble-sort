using ar.codes.common_algos;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Shouldly;

using System.Collections.Generic;
using System.Linq;

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

        [TestMethod]
        public void Traverse()
        {
            var bt = new BinaryTree<int>();
            var values = new List<int>();

            bt.AddNode(5);
            bt.AddNode(4);
            bt.AddNode(6);
            bt.AddNode(1);

            bt.Traverse(node => values.Add(node.Value));

            values.Count.ShouldBe(4);
        }
    }
}
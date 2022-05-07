using ar.codes.common_algos;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Shouldly;

namespace ar.codes.bubble_sort.test
{
    [TestClass]
    public class QuadraticEquationTests
    {
        [TestMethod]
        public void BasicTest()
        {
            var (x1, x2) = QuadraticEquation.Solve(1, 2, -3);

            x1.ShouldBe(-3);
            x2.ShouldBe(1);
        }

        [TestMethod]
        public void OneRootTest()
        {
            var (x1, x2) = QuadraticEquation.Solve(1, 2, 1);

            x1.ShouldBe(-1);
            x2.ShouldBe(null);
        }

        [TestMethod]
        public void NoRootsTest()
        {
            var (x1, x2) = QuadraticEquation.Solve(1, 2, 3);

            x1.ShouldBe(null);
            x2.ShouldBe(null);
        }
    }
}
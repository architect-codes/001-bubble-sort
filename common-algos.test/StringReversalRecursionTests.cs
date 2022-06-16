using ar.codes.common_algos;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Shouldly;

namespace ar.codes.bubble_sort.test
{
    [TestClass]
    public class StringReversalRecursionTests
    {
        [TestMethod]
        public void BasicTest()
        {
            var result = StringReversalRecursion.Reverse("ABCDE");

            result.ShouldBe("EDCBA");
        }
    }
}
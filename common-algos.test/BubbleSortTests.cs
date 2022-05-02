using Microsoft.VisualStudio.TestTools.UnitTesting;

using Shouldly;

namespace ar.codes.bubble_sort.test
{
    [TestClass]
    public class BubbleSortTests
    {
        [TestMethod]
        public void BasicTest()
        {
            // 1. setup initial data
            decimal[] data = { 73, 12, 44, 84, 23, 11, -18 };

            // 2. perform operation
            BubbleSort.PerformSort(ref data);

            // 3. validate result
            // here we need to make sure each subsequent element is greater than previous
            for (int index = 1; index < data.Length; index++)
                data[index - 1].ShouldBeLessThanOrEqualTo(data[index]);
        }

        [TestMethod]
        public void ShortDataTest()
        {
            // 1. setup initial data
            decimal[] data = { 73, 44 };

            // 2. perform operation
            BubbleSort.PerformSort(ref data);

            // 3. validate result
            // here we need to make sure each subsequent element is greater than previous
            for (int index = 1; index < data.Length; index++)
                data[index - 1].ShouldBeLessThanOrEqualTo(data[index]);
        }

        [TestMethod]
        public void VeryShortDataTest()
        {
            // 1. setup initial data
            decimal[] data = { 111 };

            // 2. perform operation
            BubbleSort.PerformSort(ref data);

            // 3. validate result
            data[0].ShouldBe(111);
        }
    }
}
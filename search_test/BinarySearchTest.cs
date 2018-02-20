using search;
using Search;
using System;
using Xunit;

namespace search_test
{
    public class BinarySearchTest
    {
        ISearch binarySearch;
        public BinarySearchTest() => this.binarySearch = new BinarySearch();

        [Fact]
        public void Search_WhenCalled_ShouldReturnThePosition()
        {
            int[] sortedInput = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            Assert.Equal<int>(7, binarySearch.Search(sortedInput, 80));
        }

        [Fact]
        public void Search_WhenElementNotFound_ShouldReturnNegativeOne()
        {
            int[] sortedInput = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            Assert.Equal<int>(-1, binarySearch.Search(sortedInput, 33));
        }
    }
}

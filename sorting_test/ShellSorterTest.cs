using sorting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Xunit;

namespace sorting_test
{
    public class ShellSorterTest
    {
        ISorter shellSorter;

        public ShellSorterTest()
        {
            this.shellSorter = new ShellSorter();
        }

        [Fact]
        public void SortElements_WhenCalled_ShouldSortTheElements()
        {
            int[] inputElements = { 10, 5, 3, 7, 8, 2, 9, 1, 4, 6 };
            this.shellSorter.SortElements(inputElements);
            Assert.True(inputElements.SequenceEqual(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }));
        }
    }
}

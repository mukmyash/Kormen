using System;
using Xunit;
using FluentAssertions;
using BenchmarkDotNet.Running;

namespace Sorting.Tests.DebugTest
{
#if DEBUG
    public class QuickSortingUnitTest
    {
        [Fact]
        public void QuickSortingUnitTest_Sort__SuccessResult()
        {
            ISorting testClass = new QuickSorting();

            int[] array = new int[] { 1, 0, 2, 9, 3, 8, 4, 7, 5, 6 };
            testClass.Sort(array);

            array.Should().Equal(0, 1, 2, 3, 4, 5, 6, 7, 8, 9);
        }
    }
#endif
}


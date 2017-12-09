using System;
using Xunit;
using FluentAssertions;
using BenchmarkDotNet.Running;

namespace Sorting.Tests.DebugTest
{

#if DEBUG
    public class InsertionSortingUnitTest
    {
        [Fact]
        public void InsertionSorting_Sort__SuccessResult()
        {
            ISorting testClass = new InsertionSorting();

            int[] array = new int[] {9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            testClass.Sort(array);

            array.Should().Equal(0, 1, 2, 3, 4, 5, 6, 7, 8, 9);
        }
    }
#endif
}

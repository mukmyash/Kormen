using System;
using Xunit;
using FluentAssertions;
using BenchmarkDotNet.Running;

namespace Sorting.Tests
{
    public class InsertionSortingUnitTest
    {
        [Fact]
        public void InsertionSorting_Sort__SuccessResult()
        {
            ISorting testClass = new InsertionSorting();

            int[] array = new int[] { 1, 0, 2, 9, 3, 8, 4, 7, 5, 6 };
            testClass.Sort(array);

            array.Should().Equal(0, 1, 2, 3, 4, 5, 6, 7, 8, 9);
        }



// #if !DEBUG
//         [Fact]
//         public void Sort()
//         {
//             var summery = BenchmarkRunner.Run<InsertionSortingLoadingTest>();
//         }
// #endif
    }
}

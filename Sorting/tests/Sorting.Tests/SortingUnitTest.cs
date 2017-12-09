using System;
using Xunit;
using FluentAssertions;
using BenchmarkDotNet.Running;
using System.Collections.Generic;

namespace Sorting.Tests
{
    public class SortingUnitTest
    {
        public static IEnumerable<object[]> GetSortingClass()
        {
            yield return new object[] { new InsertionSorting() };
            yield return new object[] { new MergeSorting() };
            yield return new object[] { new HeapSorting() };
        }

        [Theory]
        [MemberData(nameof(GetSortingClass))]
        public void Sorting_Sort__RundomArray(ISorting testClass)
        {
            var random = new Random();
            int[] array = new int[15];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(array.Length * 2);
            }
            testClass.Sort(array);

            for (int i=0;i<array.Length-1;i++){
                Assert.True(array[i]<=array[i+1]);
            }
        }

        [Theory]
        [MemberData(nameof(GetSortingClass))]
        public void Sorting_Sort__ReverseSequince(ISorting testClass)
        {
            int[] array = new int[] { 9,8,7,6,5,4,3,2,1 };
            testClass.Sort(array);

            array.Should().Equal( 1, 2, 3, 4, 5, 6, 7, 8, 9);
        }
    }
}

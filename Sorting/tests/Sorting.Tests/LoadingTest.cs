using System;
using Xunit;
using FluentAssertions;
using BenchmarkDotNet.Running;

namespace Sorting.Tests
{
    public class LoadingTest
    {
#if !DEBUG
        [Fact]
        public void Sort()
        {
            var summery = BenchmarkRunner.Run<SortingLoadingTest>();
        }
#endif
    }
}

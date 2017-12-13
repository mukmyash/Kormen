using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Columns;
using BenchmarkDotNet.Attributes.Exporters;
using BenchmarkDotNet.Attributes.Jobs;
using BenchmarkDotNet.Engines;
using BenchmarkDotNet.Exporters;

namespace Sorting.Tests
{
    [MarkdownExporter()]
    [HtmlExporter]
    [RPlotExporter]
    public class SortingLoadingTest
    {
        [Params(100, 1000, 10000)]//, 100000)]//, 1000000)]
        public int ArrayLength { get; set; }
        private int[] SortedData;

        [IterationSetup]
        public void SetupIteration()
        {
            var random = new Random();
            SortedData = new int[ArrayLength];

            for (int i = 0; i < ArrayLength; i++)
            {
                SortedData[i] = random.Next(ArrayLength * 2);
            }
        }

        [Benchmark]
        public void RandQuickSorting_Sort()
        {
            ISorting testClass = new RandQuickSorting();
            testClass.Sort(SortedData);
        }

        [Benchmark]
        public void QuickSorting_Sort()
        {
            ISorting testClass = new QuickSorting();
            testClass.Sort(SortedData);
        }

        [Benchmark]
        public void HeapSorting_Sort()
        {
            ISorting testClass = new HeapSorting();
            testClass.Sort(SortedData);
        }

        [Benchmark]
        public void InsertionSorting_Sort()
        {
            ISorting testClass = new InsertionSorting();
            testClass.Sort(SortedData);
        }
 
        [Benchmark]
        public void MergeSortingOptimized_Sort()
        {
            ISorting testClass = new MergeSortingOptimized();
            testClass.Sort(SortedData);
        }

        [Benchmark]
        public void MergeSorting_Sort()
        {
            ISorting testClass = new MergeSorting();
            testClass.Sort(SortedData);
        }

        [Benchmark]
        public void Array_Sort()
        {
            Array.Sort(SortedData);
        }
    }
}
``` ini

BenchmarkDotNet=v0.10.10, OS=ubuntu 17.10
Processor=Intel Core i3 CPU M 380 2.53GHz, ProcessorCount=4
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


```
|                     Method | ArrayLength |             Mean |         Error |        StdDev |
|--------------------------- |------------ |-----------------:|--------------:|--------------:|
|      **RandQuickSorting_Sort** |         **100** |       **174.700 us** |     **2.4566 us** |     **2.1777 us** |
|          QuickSorting_Sort |         100 |       174.449 us |     1.2462 us |     1.1657 us |
|           HeapSorting_Sort |         100 |        43.576 us |     0.4263 us |     0.3987 us |
|      InsertionSorting_Sort |         100 |         3.140 us |     0.0622 us |     0.0639 us |
| MergeSortingOptimized_Sort |         100 |        25.909 us |     0.2659 us |     0.2487 us |
|          MergeSorting_Sort |         100 |        22.590 us |     0.2745 us |     0.2568 us |
|                 Array_Sort |         100 |         1.071 us |     0.0316 us |     0.0933 us |
|      **RandQuickSorting_Sort** |        **1000** |    **17,299.433 us** |   **112.5319 us** |    **99.7566 us** |
|          QuickSorting_Sort |        1000 |    17,851.179 us |   197.2233 us |   184.4828 us |
|           HeapSorting_Sort |        1000 |       669.184 us |     7.1920 us |     6.7274 us |
|      InsertionSorting_Sort |        1000 |        31.033 us |     0.3574 us |     0.3343 us |
| MergeSortingOptimized_Sort |        1000 |       819.272 us |    15.0956 us |    14.1205 us |
|          MergeSorting_Sort |        1000 |       307.593 us |     2.0588 us |     1.8250 us |
|                 Array_Sort |        1000 |        14.056 us |     0.2758 us |     0.4903 us |
|      **RandQuickSorting_Sort** |       **10000** | **3,039,291.669 us** | **9,678.8036 us** | **9,053.5581 us** |
|          QuickSorting_Sort |       10000 | 2,957,878.533 us | 6,420.4375 us | 6,005.6807 us |
|           HeapSorting_Sort |       10000 |     8,919.539 us |    31.1612 us |    29.1482 us |
|      InsertionSorting_Sort |       10000 |    56,302.113 us |   475.3105 us |   444.6057 us |
| MergeSortingOptimized_Sort |       10000 |    50,741.368 us |   955.6274 us |   981.3589 us |
|          MergeSorting_Sort |       10000 |     3,507.991 us |     9.7661 us |     7.6247 us |
|                 Array_Sort |       10000 |       204.886 us |     3.8870 us |     4.3204 us |

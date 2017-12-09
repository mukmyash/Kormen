``` ini

BenchmarkDotNet=v0.10.10, OS=ubuntu 17.10
Processor=Intel Core i3 CPU M 380 2.53GHz, ProcessorCount=4
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


```
|                Method | ArrayLength |          Mean |       Error |      StdDev |
|---------------------- |------------ |--------------:|------------:|------------:|
|      **HeapSorting_Sort** |         **100** |     **41.401 us** |   **0.2377 us** |   **0.2107 us** |
| InsertionSorting_Sort |         100 |      3.106 us |   0.0616 us |   0.0710 us |
|     MergeSorting_Sort |         100 |     23.408 us |   0.1210 us |   0.1072 us |
|            Array_Sort |         100 |      1.074 us |   0.0258 us |   0.0761 us |
|      **HeapSorting_Sort** |        **1000** |    **659.392 us** |   **3.7994 us** |   **3.5540 us** |
| InsertionSorting_Sort |        1000 |     32.244 us |   0.3797 us |   0.3171 us |
|     MergeSorting_Sort |        1000 |    286.991 us |   0.9870 us |   0.7706 us |
|            Array_Sort |        1000 |     13.918 us |   0.2728 us |   0.4328 us |
|      **HeapSorting_Sort** |       **10000** | **10,056.281 us** |  **82.0531 us** |  **76.7525 us** |
| InsertionSorting_Sort |       10000 | 60,381.216 us | 659.9560 us | 617.3232 us |
|     MergeSorting_Sort |       10000 |  3,557.219 us |  18.1153 us |  16.9451 us |
|            Array_Sort |       10000 |    202.396 us |   2.3374 us |   2.0720 us |

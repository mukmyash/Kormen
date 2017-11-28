``` ini

BenchmarkDotNet=v0.10.10, OS=ubuntu 17.10
Processor=Intel Core i3 CPU M 380 2.53GHz, ProcessorCount=4
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


```
|                Method | ArrayLength |          Mean |       Error |      StdDev |
|---------------------- |------------ |--------------:|------------:|------------:|
| **InsertionSorting** |         **100** |      **3.070 us** |   **0.0579 us** |   **0.0667 us** |
|     MergeSorting |         100 |     22.102 us |   0.2084 us |   0.1950 us |
|            Array.Sort |         100 |      1.046 us |   0.0222 us |   0.0640 us |
| **InsertionSorting** |        **1000** |     **31.113 us** |   **0.1672 us** |   **0.1396 us** |
|     MergeSorting |        1000 |    290.897 us |   1.0390 us |   0.8676 us |
|            Array.Sort |        1000 |     14.063 us |   0.2783 us |   0.4413 us |
| **InsertionSorting** |       **10000** | **58,223.096 us** | **584.8812 us** | **488.4022 us** |
|     MergeSorting |       10000 |  3,589.097 us |  16.7026 us |  15.6236 us |
|            Array.Sort |       10000 |    206.168 us |   3.9494 us |   3.6942 us |

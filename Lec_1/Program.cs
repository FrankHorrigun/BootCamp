using System;
using System.Diagnostics;

int size = 1_000_000;
int m = 3_000;

int[] array = Enumerable.Range(1, size)
                        .Select(item => Random.Shared.Next(10))
                        .ToArray();

// Console.WriteLine($"[{string.Join(", ", array)}]");

Stopwatch sw = Stopwatch.StartNew();
// sw.Start();

int max = 0;
for (int i = 0; i < array.Length; i++)
{
    int t = 0;
    for (int j = 0; j < array.Length - m; j++) t += array[j];
    if (t > max) max = t;
}
// оптимизируем
// int max = 0;
// for (int j = 0; j < array.Length - m; j++) max += array[j];
// int t = max;
// for (int i = 0; i < array.Length; i++)
// {
//     t = t - array[i - 1] + array[i + (m - 1)];
// }


sw.Stop();
Console.WriteLine($"time={sw.ElapsedMilliseconds}");
Console.WriteLine(max);

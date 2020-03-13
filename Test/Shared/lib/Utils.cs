using System;
using System.Collections.Generic;

namespace Utils
{
  public class Printer
  {
    public void PrintArray<T>(in T[] Array)
    {
      Console.WriteLine("[{0}]", string.Join(", ", Array));
      // foreach (T item in Array)
      // {
      //   Console.WriteLine(item.ToString());
      // }
    }

    public void PrintArray<T>(in List<T> Array)
    {
      Console.WriteLine("[{0}]", string.Join(", ", Array));
    }
  }
  public class Swapper
  {
    public void Swap<T>(ref T[] input, int indexA, int indexB)
    {
      T temp = input[indexA];
      input[indexA] = input[indexB];
      input[indexB] = temp;
    }
    public void Swap<T>(ref T a, ref T b)
    {
      T temp = a;
      a = b;
      b = temp;
    }
  }
}


public abstract class ISorter<T>
{
  // Use this to swap number by reference
  protected static Utils.Swapper Swapper = new Utils.Swapper();

  // Use this array instead of Input when sorting
  // Input array cannot and may not change
  public T[] SortedArray;

  // The input array, it remains as is passed, all changes should be made on Sorted array 
  protected readonly T[] InputArray;

  public ISorter(T[] input)
    => (InputArray, SortedArray) = ((T[])input.Clone(), (T[])input.Clone());


  public abstract void Sort();
}
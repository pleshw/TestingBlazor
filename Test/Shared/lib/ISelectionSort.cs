
public class ISelectionSort : ISorterHistory<int>
{
  

  private int MinIndex = 0;
  private int Checking = 0;

  public ISelectionSort(int[] input) : base(input)
  { }

  override public void Sort()
  {
    if (!SortedArray.Equals(InputArray)) Revert();
    for (int i = 0; i < SortedArray.Length; i++)
    {
      Checking = i;
      MinIndex = i;

      for (int j = i; j < SortedArray.Length; j++)
      {
        if (SortedArray[MinIndex] > SortedArray[j])
          MinIndex = j;
      }

      if (MinIndex != Checking)
        ISelectionSort.Swapper.Swap<int>(ref SortedArray, Checking, MinIndex);

      History.Add((int[])SortedArray.Clone());
    }
  }
}
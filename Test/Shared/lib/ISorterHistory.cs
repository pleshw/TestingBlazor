public abstract class ISorterHistory<T> : ISorter<T>
{
  // the history is supposed to be updated everytime a step of sorting process is taken
  // its preferred that history update everytime data change  
  public IHistory<T[]> History;

  public ISorterHistory(T[] input)
  : base(input) => (History) = (new IHistory<T[]>(input));

  // add an instance of `this` to history everytime it changes
  public override abstract void Sort();

  public void Revert()
  {
    History.Reset();
    SortedArray = (T[])History.Get().Clone();
  }
}
using System.Collections.Generic;

public class IHistory<T>
{
  private List<T> History = new List<T>();

  private readonly T FirstElement;

  private int Pointer = 0;

  public IHistory(T first)
  {
    FirstElement = first;
    Add(FirstElement);
  }

  // adds this instance to the history
  public void Add(T instance) => History.Add(instance);

  // moves the pointer to index the next instance of history if possible
  public void Next()
  {
    if (IsEmpty()) return;
    if (Pointer + 1 < Size())
    {
      ++Pointer;
    }
  }

  // moves the pointer to index the previous instance of history if possible
  public void Prev()
  {
    if (IsEmpty()) return;
    if (Pointer - 1 >= 0)
    {
      --Pointer;
    }
  }

  // test if an index is on History list range
  private bool ValidIndex(int index) => ((index >= 0) && (index < Size()));

  // moves the pointer to `index` if it is valid
  public void GoTo(int index)
  {
    if (ValidIndex(index))
    {
      Pointer = index;
    }
  }

  public void GoToBegin() => Pointer = 0;

  public void GoToEnd() => Pointer = Size() - 1;

  // get an instance of the history 
  // if index is set and valid, it returns the instance on given index
  // else, it return the instance that is pointed
  public T Get(int index = -1)
  {
    if (ValidIndex(index))
      return History[index];
    else
      return History[Pointer];
  }

  public T Begin() => History[0];

  public T End() => History[Size() - 1];

  public int Size() => History.Count;

  public int Index() => Pointer;

  public bool IsEmpty() => (Size() == 0);

  public void Remove()
  {
    if (Size() > 0)
    {
      History.RemoveAt(Pointer);
    }

    if (Pointer >= Size())
    {
      --Pointer;
    }
  }

  public void Reset()
  {
    History = new List<T>();
    Add(FirstElement);
  }
  public T[] ToArray() => History.ToArray();
}
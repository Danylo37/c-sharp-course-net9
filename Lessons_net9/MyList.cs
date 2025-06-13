using System.Collections;

namespace Lessons_net9;

public class MyList<T> : IEnumerable<T>
{
    private T[] _array = [];
    
    public int Count => _array.Length;

    public void Add(T item)
    {
        var newArray = new T[_array.Length + 1];

        for (int i = 0; i < _array.Length; i++)
        {
            newArray[i] = _array[i];
        }
        newArray[_array.Length] = item;
        
        _array = newArray;
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < Count; i++)
        {
            yield return _array[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
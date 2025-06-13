using System.Collections;

namespace Lessons_net9;

public class MyEnumerator<T> : IEnumerator<T>
{
    private readonly T[] _array;
    private readonly int _start;
    private readonly int _count;
    private int _currentIndex;
    private const int InitialIndex = -1;

    public MyEnumerator(int start, int count, T[] array)
    {
        _array = array;
        _start = start;
        _count = count;
        _currentIndex = InitialIndex;
    }
    
    public bool MoveNext()
    {
        if (_currentIndex + 1 < _count)
        {
            _currentIndex++;
            return true;
        }
        return false;
    }

    public void Reset()
    {
        _currentIndex = InitialIndex;
    }

    public T Current
    {
        get
        {
            if (_currentIndex < 0 || _currentIndex >= _count)
            {
                throw new InvalidOperationException("Enumerator is in an invalid state");
            }
            return _array[_start + _currentIndex];
        }
    }

    object? IEnumerator.Current => Current;

    public void Dispose()
    {
        
    }
}
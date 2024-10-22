public class MyList
{
    private int[] _array = new int[4];
    private int _count = 0;

    public int Count
    {
        get { return _count; }
    }

    public void Add(int item) 
    {
        if (_count >= _array.Length)
        {
            int[] newArray = new int[_array.Length * 2];
            Array.Copy(_array, newArray, _array.Length);
            _array = newArray;
        }
        _array[_count] = item;
        _count++;
    }


    public void RemoveAt(int index) 
    {
        if (index < 0 || index >= _count)
        {
            Console.WriteLine($"index {index} outside of list");
            return;
        }

        for (int i = index; i < _count-1; i++)
        {
            _array[i] = _array[i+1];

        }

        _count--;
        _array[_count] = 0;
    }

    public void Remove(int item) 
    {
        for(int i = 0; i < _count; i++)
        {
            if (_array[i] == item)
            {
                RemoveAt(i);
                return;
            }
        }
        Console.WriteLine($"item {item} is not in the list");
    }

    public void RemoveRange(int index1, int index2) 
    {
        if (index1 > index2 || index1 < 0 || index1 >= _count || index2 < 0 || index2 >= _count)
        {
            Console.WriteLine("Incorrect range");
            return;
        }

        int lenghtRange = index2 - index1 + 1;

        for (int i = index1; i < _count - lenghtRange; i++)
            _array[i] = _array[i + lenghtRange];
        
        for (int i = _count - lenghtRange; i < _count; i++)
            _array[i] = default;

        _count -= lenghtRange;
    }

    public void Insert(int index, int item) 
    {
        if (index < 0 || index > _count)
        {
            Console.WriteLine("Incorrect index");
            return;
        }

        if (_count >= _array.Length)
        {
            int[] newArray = new int[_array.Length * 2];
            Array.Copy(_array, newArray, _array.Length);
            _array = newArray;
        }

        for (int i = _count; i > index; i--)
            _array[i] = _array[i - 1];


        _array[index] = item;
        _count++;
    }

    public void Clear() 
    {
        while(_count > 0)
        {
            _count--;
            _array[_count] = 0;
        }
    }

    public string ToString() 
    {
        return string.Join(", ", _array.Take(_count));
    }
}
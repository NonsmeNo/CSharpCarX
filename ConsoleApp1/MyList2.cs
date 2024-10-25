public class MyList2<TItem> 
{
    private TItem[] _array;
    private int _count = 0;
    private int _capacity = 4;

    public int Capacity
    {
        set 
        {
            if (_capacity < value)
            {
                System.Array.Resize(ref _array, value);
                _capacity = value;
            }
        }
        get => _capacity;        
    }

    public int Count => _count;

    public MyList2()
    {
        _array = new TItem[_capacity];
    }

    public MyList2(int capacity)
    {
        _capacity = capacity;
        _array = new TItem[_capacity];
    }

    public void Add(TItem item)
    {
        if (_count >= _capacity)
        {
            this.Capacity *= 2;
        }

        _array[_count++] = item;
    }


    public void RemoveAt(int index)
    {
        if (index < 0 || index >= _count)
        {
            Console.WriteLine("Некорректный индекс");
            return;
        }

        for (int i = index; i < _count - 1; i++)
        {
            _array[i] = _array[i + 1];
        }
        
        _array[--_count] = default(TItem);
    }

    public void Remove(TItem item)
    {
        int index = IndexOf(item);
        RemoveAt(index);
        
    }

    public void RemoveRange(int index1, int index2)
    {
        if (index1 < 0 || index2 >= _count || index1 > index2)
        {
            Console.WriteLine("Некорректный индекс");
            return;
        }

        int range = index2 - index1 + 1;

        for (int i = index1; i < _count - range; i++)
        {
            _array[i] = _array[i + range];
        }

        _count -= range;
        for (int i = _count; i < _count + range; i++)
        {
            _array[i] = default(TItem);
        }
    }

    public void Insert(int index, TItem item)
    {
        if (index < 0 || index > _count)
        {
            Console.WriteLine("Некорректный индекс");
            return;
        }

        if (_count >= _capacity)
        {
            this.Capacity *= 2;
        }

        for (int i = _count; i > index; i--)
        {
            _array[i] = _array[i - 1];
        }

        _array[index] = item;
        _count++;
    }

    public void Clear()
    {
        _array = new TItem[_capacity];
        _count = 0;
    }

    public override string ToString()
    {
        return string.Join(", ", _array.Take(_count));
    }

    public int IndexOf(TItem item) //возвращает индекс
    {
        for (int i = 0; i < _count; i++)
        {
            if (EqualityComparer<TItem>.Default.Equals(_array[i], item)) 
            {
                return i;
            }
        }
        return -1;
    }

    public void ForEach (System.Action<TItem> action) //проходится по всем элементам и вызывает Action
    {
        foreach (TItem item in _array)
        {
            action?.Invoke(item);
        }
    }

    public TItem Find(System.Func<TItem, bool> predicate) //находит элемент System.Predicate<TItem> predicate
    {
        foreach (TItem item in _array)
        {
           if (predicate(item)) 
           {
                return item;
           }
        }
        
        return default(TItem);
    }

    public void Sort(System.Func<TItem, TItem, int> sort)
    {
        for (int i = 0; i < _count - 1; i++)
        {
            for (int j = 0; j < _count - i - 1; j++)
            {
                var item1 = _array[j];
                var item2 = _array[j + 1];

                if (sort(item1, item2) > 0)
                {
                    _array[j] = item2;
                    _array[j + 1] = item1;
                }
            }
        }
    }

}

//
public class Mylist
{
    private int[] _array = new int[4];
    private int _count = 0;

    public void Add(int item) 
    {
        if (_count < _array.Length)
        {
            _array[_count] = item;
            _count++;
        }
        else
        {
            Console.WriteLine($"The list is full, element {item} will not be added");
        }
    }

    public void Print()
    {
        for (int i = 0; i < _array.Length; i++)
            Console.Write(_array[i] + " ");
        
        Console.WriteLine();
    }

    public void Remove(int item) 
    {
        bool f = false;
        
        for (int i = 0; i < _array.Length; i++)
        {
            if (_array[i] == item)
            {
               
            }
        }
    }

    public void RemoveAt(int index) 
    {
        
    }

    public void RemoveRange(int index1, int index2) 
    {
        
    }

    public void Insert(int index, int item) 
    {

    }

    public void Clear() 
    {

    }

    public void ToString(int item) 
    {

    }
    
}
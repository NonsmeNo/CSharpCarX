using System.Collections.Specialized;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine($"bool size {sizeof(bool)}");
        Console.WriteLine($"byte size {sizeof(byte)} min: {byte.MinValue} max: {byte.MaxValue}");
        Console.WriteLine($"short size {sizeof(short)} min: {short.MinValue} max: {short.MaxValue}");
        Console.WriteLine($"int size {sizeof(int)} min: {int.MinValue} max: {int.MaxValue}");
        Console.WriteLine($"float size {sizeof(float)} min: {float.MinValue} max: {float.MaxValue}");
        Console.WriteLine($"long size {sizeof(long)} min: {long.MinValue} max: {long.MaxValue}");
        Console.WriteLine();

        //ref передаем ссылку
        //out обязательно присвоить значение переменной, также передаем ссылку
        //in переменную нельзя изменить


        //работа с MyList
        MyList list = new MyList();

        for (int i = 0; i < 10; i++)
            list.Add(i*5);

        Console.WriteLine($"Количество элементов в списке: {list.Count}");
        Console.WriteLine($"Список: {list.ToString()}");
        Console.WriteLine();

        Console.WriteLine("Удаление элемента со значением 30");
        list.Remove(30);
        Console.WriteLine(list.ToString());
        Console.WriteLine();

        Console.WriteLine("Удаление элемента со значением 100");
        list.Remove(100);
        Console.WriteLine(list.ToString());
        Console.WriteLine();

        Console.WriteLine("Удаление элемента с индексом 2");
        list.RemoveAt(2);
        Console.WriteLine(list.ToString());
        Console.WriteLine();

        Console.WriteLine("Вставка элемента 55 с индексом 3");
        list.Insert(3, 55);
        Console.WriteLine(list.ToString());
        Console.WriteLine();

        Console.WriteLine("Вставка элемента 55 с индексом 10");
        list.Insert(10, 55);
        Console.WriteLine(list.ToString());
        Console.WriteLine();

        Console.WriteLine("Удаление элементов со 2 по 5 индекс");
        list.RemoveRange(2, 5);
        Console.WriteLine(list.ToString());
        Console.WriteLine();

        Console.WriteLine("Удаление элементов со 2 по 15 индекс");
        list.RemoveRange(2, 15);
        Console.WriteLine(list.ToString());
        Console.WriteLine();

        Console.WriteLine("Очищение списка");
        list.Clear();
        Console.WriteLine($"Список: {list.ToString()}");
        Console.WriteLine();


        // //работа с MyList2 (Generics)
        MyList2<int> myList = new MyList2<int>();
        
        for (int i = 10; i >= 0; i--)
            myList.Add(i*5);
        
        Console.WriteLine("Список: " + myList);
        
        // Удаление элемента по индексу
        myList.RemoveAt(2); // Удаляет элемент 3
        Console.WriteLine($"После удаления элемента по индексу 2: {myList} \n");
        
        // Удаление конкретного элемента
        myList.Remove(4); // Удаляет элемент 4
        Console.WriteLine($"После удаления элемента 4: {myList} \n");

        // Удаление
        myList.Remove(100); // Удаляет элемент 4
        Console.WriteLine($"После удаления элемента 100: {myList} \n");
        
        // Вставка элемента
        myList.Insert(1, 10); // Вставляет 10 на индекс 1
        Console.WriteLine($"После вставки 10 на индекс 1: {myList} \n");
        
        // Поиск элемента
        int index = myList.IndexOf(10);
        Console.WriteLine($"Индекс элемента 10: {myList} \n");
        
        // Применение ForEach
        myList.ForEach(i => Console.WriteLine($"Элемент: {i}"));
        Console.WriteLine();

        // Поиск с помощью предиката
        int item = myList.Find(x => x == 0);
        Console.WriteLine($"Найти первый элемент, который равен 0, вернуть индекс: {myList.IndexOf(item)} \n");
        Console.WriteLine("Список: " + myList);

        //Сортировка
        myList.Sort((x1, x2) => x1.CompareTo(x2));
        Console.WriteLine($"Отсортированный писок: {myList} \n");

        // Очистка списка
        myList.Clear();
        Console.WriteLine($"После очистки списка: {myList} \n");
    }   
}

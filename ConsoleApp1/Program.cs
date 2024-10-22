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
    }   
}

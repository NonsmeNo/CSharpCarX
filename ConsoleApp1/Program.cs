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

         List<int> list = new List<int>(10);
        list.Add(10);

         Console.WriteLine($"list - {string.Join(", ", list)}");

         Mylist list2 = new Mylist();

         list2.Add(10);
         list2.Add(15);
         list2.Add(20);
         list2.Add(25);
         list2.Add(30);
         list2.Print();




    }

    //ref передаем ссылку
    //out обязательно присвоить значение переменной, также передаем ссылку
    //in переменную нельзя изменить
    
    public static void f(int i) 
    {

    }


}

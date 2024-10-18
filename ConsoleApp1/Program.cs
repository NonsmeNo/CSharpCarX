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

        string s = "abcd";
        
        byte[] b = new byte[8];
        s+= "e";
        char c = s[1];
        s = s.Insert(0, "f");

        Console.WriteLine($"{s} - {b[7]}");

        List<int> list = new List<int>();

        for (int j = 1; j <= 5; j++) 
            list.Add(j);
        
        Console.WriteLine($"list - {string.Join(", ", list)}");
        list.Remove(2);

        



        int i = 0;
        long l = int.MaxValue;
        i = (int)l;

        object o = i;
        i = (int)o;


         //f(ref o); 
        Console.WriteLine($"{o}");


    }

    //ref передаем ссылку
    //out обязательно присвоить значение переменной, также передаем ссылку
    //in переменную нельзя изменить
    
    public static void f(in int i) 
    {

    }


}

using System;

class Program
{
    static void Main(string[] args)
    {
        var ifade = " Merhaba programlama dünyası. ";
        Console.WriteLine(ifade);
        Console.WriteLine(ifade.Length);
        Console.WriteLine(ifade.ToUpper());
        Console.WriteLine(ifade.ToLower());
        Console.WriteLine(ifade.TrimStart());
        Console.WriteLine(ifade.TrimEnd());
        Console.WriteLine(ifade[0]);
        Console.WriteLine(ifade[1]);
        Console.WriteLine(ifade[ifade.Length-1]);




        Console.ReadKey();  
    }
}

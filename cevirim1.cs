using System;


namespace ConsollApp4
{
    public class Program
    {

        static void Main(string[] args)
        {
            int i = 0;
            while (i<10)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.WriteLine("Döngü sonu.");
            Console.ReadKey();
        }
    }
}

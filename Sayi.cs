using System;

namespace ConsollApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı gir: ");
            int sayı = Convert.ToInt32(Console.ReadLine());

            if (sayı> 0)
            {
                Console.WriteLine("Pozitif sayı");
            }
            else if (sayı < 0)
            {
                Console.WriteLine("Negatif sayı");
            }
            else
            {
                Console.WriteLine("Sıfır");
            }

            Console.ReadKey();
            
        }
    }
}

using System;

namespace ConsollApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Notunu ir 0-100: ");
            int not = Convert.ToInt32(Console.ReadLine());

            if (not >= 90)
            {
                Console.WriteLine("A - Mükemmel");
            }
            else if (not >= 80)
            {
                Console.WriteLine("B - Çok iyi.");
            }
            else if (not >= 70)
            {
                Console.WriteLine("C - İyi");
            }
            else if (not >= 60)
            {
                Console.WriteLine("D - Geçer");
            }
            else
            {
                Console.WriteLine("F - Kaldı");
            }

            Console.ReadKey();
        }
    }
}

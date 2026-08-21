using System;

namespace ConsollApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yaşını gir: ");
            int yas = Convert.ToInt32(Console.ReadLine());


            if (yas < 18)
            {
                Console.WriteLine("Çocuk/Ebeeyn izni gerekli");
            }
            else if (yas < 65)
            {
                Console.WriteLine("Yetişkin");
            }
            else
            {
                Console.WriteLine("Emekli");
            }
            Console.ReadKey();
            
        }
    }
}

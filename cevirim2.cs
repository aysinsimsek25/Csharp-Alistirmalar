using System;


namespace ConsollApp4
{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı giriniz!");
            int n = Convert.ToInt32(Console.ReadLine());

            int i = 2;
            do
            {

                Console.Write("{0,3}",i);
                i = i + 2;
            } while (i <= n);


            /*
             * int sayac = 10;
            while (sayac > 0)
            {
                Console.WriteLine("{0,-3} {1,-3}", sayac, sayac * sayac);
                sayac = sayac - 1;
            }
            */
            Console.ReadKey();
        }
    }
}







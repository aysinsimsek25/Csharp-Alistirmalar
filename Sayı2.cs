namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayı giriniz.");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a%2==0)
            {
                Console.WriteLine("Çift"); ;
            }
            else
            {
                Console.WriteLine("Tek");
            }
                Console.WriteLine();
                Console.ReadKey();

                /*
                 * if (sayi%2==0)
                {
                    Console.WriteLine($"{sayi} çift bir sayıdır.");
                }
                else
                {
                    Console.WriteLine($"{sayi} tek bir sayıdır.");
                }
                if  (n<0)
                { 
                   Console.WriteLine($"|{n}| = {n*-1}");
                }
                else
                {
                    Console.WriteLine($"|{n} | = {n}");
                }

                 */

            }
            
        }
    }

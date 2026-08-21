namespace ConsollApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir karakter girin.");
            var k = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (char.IsDigit(k))
            {
                Console.WriteLine("Güçlü: Rakam girdin.");
            }
            else if (char.IsUpper(k))
            {
                Console.WriteLine("Güçlü: Büyük harf girdin.");
            }
            else if (char.IsLower(k))
            {
                Console.WriteLine("Zayıf: Küçük harf girdin.");
            }
            else
            {
                Console.WriteLine("Geçersiz karakter.");
            }

            Console.ReadKey();
        }
    }
}

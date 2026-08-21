using System;
using System.Linq;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== INTIHAL HESAPLAMA PROGRAMI =====");

            // 1. Kullanıcıdan 2 metin al
            Console.WriteLine("\n1. METNI GIRIN:");
            string metin1 = Console.ReadLine().ToLower();

            Console.WriteLine("\n2. METNI GIRIN:");
            string metin2 = Console.ReadLine().ToLower();

            // 2. Metinleri kelimelere böl
            string[] kelimeler1 = metin1.Split(' ', '.', ',', '!', '?');
            string[] kelimeler2 = metin2.Split(' ', '.', ',', '!', '?');

            // Boş kelimeleri temizle
            kelimeler1 = kelimeler1.Where(k => !string.IsNullOrWhiteSpace(k)).ToArray();
            kelimeler2 = kelimeler2.Where(k => !string.IsNullOrWhiteSpace(k)).ToArray();

            // 3. Ortak kelimeleri say - if ile kontrol
            int ortakKelimeSayisi = 0;
            foreach (string kelime1 in kelimeler1)
            {
                if (kelimeler2.Contains(kelime1))
                {
                    ortakKelimeSayisi++;
                }
            }

            // 4. Benzerlik yüzdesini hesapla
            double toplamKelime = kelimeler1.Length + kelimeler2.Length;
            double benzerlikOrani = 0;

            if (toplamKelime > 0)
            {
                benzerlikOrani = (ortakKelimeSayisi * 2 / toplamKelime) * 100;
            }

            // 5. Sonucu yazdır
            Console.WriteLine("\n===== SONUC =====");
            Console.WriteLine($"Metin 1 kelime sayısı: {kelimeler1.Length}");
            Console.WriteLine($"Metin 2 kelime sayısı: {kelimeler2.Length}");
            Console.WriteLine($"Ortak kelime sayısı: {ortakKelimeSayisi}");
            Console.WriteLine($"Benzerlik Oranı: %{Math.Round(benzerlikOrani, 2)}");

            // 6. Yorum yap - if else
            if (benzerlikOrani >= 80)
            {
                Console.WriteLine("UYARI: Yuksek intihal riski!");
            }
            else if (benzerlikOrani >= 50)
            {
                Console.WriteLine("Dikkat: Orta duzey benzerlik var.");
            }
            else if (benzerlikOrani >= 20)
            {
                Console.WriteLine("Dusuk benzerlik.");
            }
            else
            {
                Console.WriteLine("Metinler birbirinden farkli.");
            }

            Console.ReadKey();
        }
    }
}

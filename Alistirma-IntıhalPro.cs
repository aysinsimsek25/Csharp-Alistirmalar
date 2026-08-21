using System;
using System.IO; // DOSYA OKUMAK İÇİN
using System.Linq;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== DOSYADAN INTIHAL HESAPLAMA =====");
            Console.WriteLine("Dosyalari konsolun ustune surukle birak!");

            // 1. Kullanıcıdan dosya yollarını sürükle bırak ile al
            Console.Write("\n1. Dosyayi buraya surukle birak + Enter: ");
            string dosyaYolu1 = Console.ReadLine().Trim('"'); // tırnakları siler

            Console.Write("2. Dosyayi buraya surukle birak + Enter: ");
            string dosyaYolu2 = Console.ReadLine().Trim('"');

            // 2. Dosyaları oku - if ile kontrol et
            string metin1 = "";
            string metin2 = "";

            if (File.Exists(dosyaYolu1) && File.Exists(dosyaYolu2))
            {
                metin1 = File.ReadAllText(dosyaYolu1).ToLower();
                metin2 = File.ReadAllText(dosyaYolu2).ToLower();
            }
            else
            {
                Console.WriteLine("\nHATA: Dosyalardan biri bulunamadi!");
                Console.WriteLine("Dosyanin uzantisinin .txt oldugundan emin ol.");
                Console.ReadKey();
                return; // programı bitir
            }

            // 3. Kelimelere böl
            char[] ayraclar = { ' ', '.', ',', '!', '?', '\n', '\r', ';', ':' };
            string[] kelimeler1 = metin1.Split(ayraclar, StringSplitOptions.RemoveEmptyEntries);
            string[] kelimeler2 = metin2.Split(ayraclar, StringSplitOptions.RemoveEmptyEntries);

            // 4. Ortak kelimeleri say
            int ortakKelimeSayisi = 0;
            foreach (string kelime1 in kelimeler1)
            {
                if (kelimeler2.Contains(kelime1))
                {
                    ortakKelimeSayisi++;
                }
            }

            // 5. Benzerlik yüzdesi
            double toplamKelime = kelimeler1.Length + kelimeler2.Length;
            double benzerlikOrani = 0;

            if (toplamKelime > 0)
            {
                benzerlikOrani = (ortakKelimeSayisi * 2 / toplamKelime) * 100;
            }

            // 6. Sonucu yazdır
            Console.WriteLine("\n===== SONUC =====");
            Console.WriteLine($"Dosya 1 kelime: {kelimeler1.Length}");
            Console.WriteLine($"Dosya 2 kelime: {kelimeler2.Length}");
            Console.WriteLine($"Ortak kelime: {ortakKelimeSayisi}");
            Console.WriteLine($"Benzerlik Orani: %{Math.Round(benzerlikOrani, 2)}");

            if (benzerlikOrani >= 80)
                Console.WriteLine("UYARI: Yuksek intihal riski!");
            else if (benzerlikOrani >= 50)
                Console.WriteLine("Dikkat: Orta duzey benzerlik var.");
            else
                Console.WriteLine("Dusuk benzerlik.");

            Console.WriteLine("\nCikmak icin bir tusa bas...");
            Console.ReadKey();
        }
    }
}
